using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.DAL;

namespace Loja.Relatorio
{
    public partial class FrmParametroProdutosPorCategoria : Form
    {
        public FrmParametroProdutosPorCategoria()
        {
            InitializeComponent();
        }

        private void FrmParametroProdutosPorCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormParametroProdutoPorCategoria = null;
        }

        private void FrmParametroProdutosPorCategoria_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void gerarRelatorio_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormRelatorioProdutoPorCategoria == null)
                MeusFormularios.FormRelatorioProdutoPorCategoria = new FormRelatorioProdutosPorCategoria();

            MeusFormularios.FormRelatorioProdutoPorCategoria.codigoCategoria = (int)comboCategoria.SelectedValue;
            MeusFormularios.FormRelatorioProdutoPorCategoria.Show();
            MeusFormularios.FormRelatorioProdutoPorCategoria.Focus();
        }
    }
}
