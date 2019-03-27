using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Operacion_multiplicacion
    {
        double m1, m2, resultado;

        public double M1 { get => m1; set => m1 = value; }
        public double M2 { get => m2; set => m2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        public Operacion_multiplicacion()
        {
            this.m1 = 0;
            this.m2 = 0;
        }

        public double Calcular()
        {
            resultado = m1 * m2;
            return resultado;

        }
    }
}
