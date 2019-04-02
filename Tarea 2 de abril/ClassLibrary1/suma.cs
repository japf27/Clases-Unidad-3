using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class suma
    {
        private double s1, s2, resultado;

        public double S2
        {
            get { return s2; }
            set { s2 = value; }
        }

        public double S1
        {
            get { return s1; }
            set { s1 = value; }
        }

        public double calcular()
        {
            resultado = S1 + S2;
            return resultado;
        }
    }
}
