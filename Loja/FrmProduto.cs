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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProduto = null;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void carregaDados()
        {
            produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();

            this.dtGVProdutos.Refresh();
            produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;

            //((Categoria)categoriaBindingSource.Current).Codigo            
            //((Categoria)categoriaBindingSource.Current).Descricao;            
            MessageBox.Show("gravado com sucesso!" + ((Categoria)categoriaBindingSource.Current).Codigo );
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("excluído com sucesso!!!");
        }

        private void produtoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.Value != null && e.ColumnIndex == 3)
            {                
                e.Value = ((Categoria)e.Value).Descricao;
            }
        }
    }
}
