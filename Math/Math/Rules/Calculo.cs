using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Math.Rules
{
    public class Calculo
    {
        public List<long> Divisores { get; set; }
        public List<long> DivisoresPrimos { get; set; }

        public Calculo()
        {
            this.Divisores = new List<long>();
            this.DivisoresPrimos = new List<long>();
        }

        public Calculo CalcularDivisoresEDivisoresPrimos(long numero)
        {
            var calculo = new Calculo();

            calculo.Divisores = this.CalcularDivisores(numero);

            foreach(long numeroDivisor in calculo.Divisores)
            {
                if(this.IndicaDivisorPrimo(numeroDivisor))
                {
                    calculo.DivisoresPrimos.Add(numeroDivisor);
                }
            }

            return calculo;
        }

        public List<long> CalcularDivisores(long numero)
        {
            var divisores = new List<long>();

            if(numero > 0)
            {
                for(long numeroDivisor = 1; numeroDivisor <= numero; numeroDivisor++)
                {
                    if(numero % numeroDivisor == 0)
                    {
                        divisores.Add(numeroDivisor);
                    }
                }
            }
            else if(numero < 0)
            {
                for(long numeroDivisor = -1; numeroDivisor >= numero; numeroDivisor--)
                {
                    if(numero % numeroDivisor == 0)
                    {
                        divisores.Add(numeroDivisor);
                    }
                }
            }

            return divisores;
        }

        public bool IndicaDivisorPrimo(long numero)
        {
            if(numero > -2 && numero < 2)
            {
                return false;
            }

            if(numero > 1)
            {
                for(long numeroDivisor = 2; numeroDivisor < numero; numeroDivisor++)
                {
                    if(numero % numeroDivisor == 0)
                    {
                        return false;
                    }
                }
            }
            else if(numero < -1)
            {
                for(long numeroDivisor = -2; numeroDivisor > numero; numeroDivisor--)
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
