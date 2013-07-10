using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.Relatorio;

namespace Loja
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null)
                MeusFormularios.FormCategoria = new FrmCategoria();

            MeusFormularios.FormCategoria.Show();
            MeusFormularios.FormCategoria.Focus();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null)
                MeusFormularios.FormProduto = new FrmProduto();

            MeusFormularios.FormProduto.Show();
            MeusFormularios.FormProduto.Focus();
        }

        private void produtoPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProdutoPorCategoria == null)
                MeusFormularios.FormProdutoPorCategoria = new FrmProdutoPorCategoria();

            MeusFormularios.FormProdutoPorCategoria.Show();
            MeusFormularios.FormProdutoPorCategoria.Focus();
        }

        private void produtoPorCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormParametroProdutoPorCategoria == null)
                MeusFormularios.FormParametroProdutoPorCategoria = new Loja.Relatorio.FrmParametroProdutosPorCategoria();


            MeusFormularios.FormParametroProdutoPorCategoria.Show();
            MeusFormularios.FormParametroProdutoPorCategoria.Focus();

        }
    }
}
