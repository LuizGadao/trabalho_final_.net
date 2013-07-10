using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loja.Relatorio;

namespace Loja
{
    public class MeusFormularios
    {
        public static FrmCategoria FormCategoria { get; set; }
        public static FrmProduto FormProduto { get; set; }
        public static FrmProdutoPorCategoria FormProdutoPorCategoria { get; set; }
        public static FormRelatorioProdutosPorCategoria FormRelatorioProdutoPorCategoria { get; set; }
        public static FrmParametroProdutosPorCategoria FormParametroProdutoPorCategoria { get; set; }
    }
}
