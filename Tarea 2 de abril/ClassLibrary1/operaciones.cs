using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class operaciones
    {

        private double val1, val2, resultado;

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double Val2
        {
            get { return val2; }
            set { val2 = value; }
        }

        public double Val1
        {
            get { return val1; }
            set { val1 = value; }
        }

        public double calcular()
        {
            Resultado = Val1 + Val2;
            return Resultado;
        }
    }
}
