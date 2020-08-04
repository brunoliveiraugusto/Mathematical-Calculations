using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Math.Rules
{
    public class Divisor
    {
        public List<double> NumerosDivisores { get; set; }

        public Divisor()
        {
            this.NumerosDivisores = new List<double>();
        }

        public List<double> CalcularDivisores(double numero)
        {
            for(double numeroDivisor = 0; numeroDivisor <= numero; numeroDivisor++)
            {
                if(numero % numeroDivisor == 0.0)
                {
                    this.NumerosDivisores.Add(numeroDivisor);
                }
            }

            return this.NumerosDivisores;
        }
    }
}
