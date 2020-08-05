using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Math.Rules
{
    public class Calculo
    {
        public List<double> Divisores { get; set; }
        public List<double> DivisoresPrimos { get; set; }

        public Calculo()
        {
            this.Divisores = new List<double>();
            this.DivisoresPrimos = new List<double>();
        }

        public Calculo CalcularDivisoresEDivisoresPrimos(double numero)
        {
            var calculo = new Calculo();

            calculo.Divisores = this.CalcularDivisores(numero);

            foreach(double numeroDivisor in calculo.Divisores)
            {
                if(this.IndicaDivisorPrimo(numeroDivisor))
                {
                    calculo.DivisoresPrimos.Add(numeroDivisor);
                }
            }

            return calculo;
        }

        public List<double> CalcularDivisores(double numero)
        {
            var divisores = new List<double>();

            if(numero > 0)
            {
                for(double numeroDivisor = 0; numeroDivisor <= numero; numeroDivisor++)
                {
                    if(numero % numeroDivisor == 0)
                    {
                        divisores.Add(numeroDivisor);
                    }
                }
            }
            else if(numero < 0)
            {
                for(double numeroDivisor = 0; numeroDivisor >= numero; numeroDivisor--)
                {
                    if(numero % numeroDivisor == 0)
                    {
                        divisores.Add(numeroDivisor);
                    }
                }
            }

            return divisores;
        }

        public bool IndicaDivisorPrimo(double numero)
        {
            if(numero > -2 && numero < 2)
            {
                return false;
            }

            if(numero > 1)
            {
                for(double numeroDivisor = 2; numeroDivisor < numero; numeroDivisor++)
                {
                    if(numero % numeroDivisor == 0)
                    {
                        return false;
                    }
                }
            }
            else if(numero < -1)
            {
                for(double numeroDivisor = -2; numeroDivisor > numero; numeroDivisor--)
                {
                    if(numero % numeroDivisor == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
