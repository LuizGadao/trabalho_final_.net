using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.DAL;

namespace Loja
{
    public partial class FrmCategoria : Form
    {
        private Categoria CategoriaCorrente
        {
            get
            {
                return (Categoria) this.categoriaBindingSource.Current;
            }            
        }

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCategoria = null;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (valida())
                gravar();
            else
                MessageBox.Show("Campo nome Categoria é obrigatorio!");
        }

        private void gravar()
        {
            this.categoriaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            
            MessageBox.Show("Categoria armazenada com sucesso!");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza?", "Confirmação " + this.CategoriaCorrente.Codigo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (categoriaPossuiProduto(this.CategoriaCorrente))
                    MessageBox.Show("Você não pode excluir uma categoria que tem produtos");
                else
                {
                    excluir();
                }
            }            
        }

        private void excluir()
        {
            this.categoriaBindingSource.RemoveCurrent();            
            DataContextFactory.DataContext.SubmitChanges();
        }

        private bool categoriaPossuiProduto(Categoria categoria)
        {
            var produto = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == categoria.Codigo);

            return produto.Count() > 0;
        }

        private bool valida()
        {
            if (txtCategoria.Text.Trim() == string.Empty)
                return false;

            return true;
        }

        
    }
}
