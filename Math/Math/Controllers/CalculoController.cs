using Math.Rules;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Math.Controllers
{
    public class CalculoController : Controller
    {
        [Route("Calculo/CalcularDivisoresEDivisoresPrimos")]
        [HttpGet]
        public Calculo CalcularDivisoresEDivisoresPrimos(double numero)
        {
            return new Calculo().CalcularDivisoresEDivisoresPrimos(numero);
        }
    }
}
