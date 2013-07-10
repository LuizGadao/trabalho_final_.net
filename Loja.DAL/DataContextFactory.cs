using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.DAL
{
    public class DataContextFactory
    {
        private static LojaDataContext dataContext;

        public static LojaDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new LojaDataContext();

                return dataContext;
            }
        }

    }
}
