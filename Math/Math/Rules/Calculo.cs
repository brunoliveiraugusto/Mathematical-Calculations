using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Math.Rules
{
    public class Calculo
    {
        public List<double> NumerosDivisores { get; set; }
        public List<double> NumerosPrimos { get; set; }

        public Calculo()
        {
            this.NumerosDivisores = new List<double>();
            this.NumerosPrimos = new List<double>();
        }

        public Calculo CalcularNumerosDivisoresENumerosPrimos(double numero)
        {
            var calculo = new Calculo();

            calculo.NumerosDivisores = this.CalcularNumerosDivisores(numero);

            foreach (double numeroDivisor in calculo.NumerosDivisores)
            {
                if(this.IndicaNumeroPrimo(numeroDivisor))
                {
                    calculo.NumerosPrimos.Add(numeroDivisor);
                }
            }

            return calculo;
        }

        public List<double> CalcularNumerosDivisores(double numero)
        {
            var numerosDivisores = new List<double>();

            if(numero > 0)
            {
                for (double numeroDivisor = 0; numeroDivisor <= numero; numeroDivisor++)
                {
                    if (numero % numeroDivisor == 0)
                    {
                        numerosDivisores.Add(numeroDivisor);
                    }
                }
            }
            else if(numero < 0)
            {
                for (double numeroDivisor = 0; numeroDivisor >= numero; numeroDivisor--)
                {
                    if (numero % numeroDivisor == 0)
                    {
                        numerosDivisores.Add(numeroDivisor);
                    }
                }
            }

            return numerosDivisores;
        }

        public bool IndicaNumeroPrimo(double numero)
        {
            if(numero > -2 && numero < 2)
            {
                return false;
            }

            if(numero > 1)
            {
                for (double numeroDivisor = 2; numeroDivisor < numero; numeroDivisor++)
                {
                    if (numero % numeroDivisor == 0)
                    {
                        return false;
                    }
                }
            }
            else if(numero < -1)
            {
                for (double numeroDivisor = -2; numeroDivisor > numero; numeroDivisor--)
                {
                    if (numero % numeroDivisor == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
