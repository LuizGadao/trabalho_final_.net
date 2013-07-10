using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Loja.Relatorio
{
    public partial class FormRelatorioProdutosPorCategoria : Form
    {

        public int codigoCategoria { set; get; }

        public FormRelatorioProdutosPorCategoria()
        {
            InitializeComponent();
        }

        private void FormRelatorioProdutosPorCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelatorioProdutoPorCategoria = null;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            string caminhoRelatorio = Properties.Settings.Default.CaminhoRelatorio;
            rd.Load(caminhoRelatorio + "ProdutoPorCategoria.rpt");

            ParameterField parametro = rd.ParameterFields["codigoCategoria"];
            parametro.CurrentValues.AddValue(codigoCategoria);

            crystalReportViewer1.ReportSource = rd;
        }
    }
}
