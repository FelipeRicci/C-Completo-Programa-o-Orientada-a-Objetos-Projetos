using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    class ConversorDeMoeda
    {
        public static double cotacao;
        public static double quantidade;

        public static double ValorASerPago()
        {
            return quantidade * cotacao + (quantidade * cotacao * 0.06);
        }
    }
}
