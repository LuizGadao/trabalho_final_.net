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
    public partial class FrmProdutoPorCategoria : Form
    {
        public FrmProdutoPorCategoria()
        {
            InitializeComponent();
        }

        private void FrmProdutoPorCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            MeusFormularios.FormProdutoPorCategoria = null;
        }

        private void FrmProdutoPorCategoria_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {
            this.comboCategoria.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar((int)comboCategoria.SelectedValue);
        }

        private void pesquisar(int idCategoria)
        {
            this.produtoBindingSource.DataSource =
                DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == idCategoria);
        }
    }
}
