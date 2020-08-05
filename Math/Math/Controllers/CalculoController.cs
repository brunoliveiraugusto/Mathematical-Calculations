using Math.Rules;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Math.Controllers
{
    public class CalculoController : Controller
    {
        [Route("Calculo/CalcularNumerosDivisoresENumerosPrimos")]
        [HttpGet]
        public Calculo CalcularNumerosDivisoresENumerosPrimos(double numero)
        {
            return new Calculo().CalcularNumerosDivisoresENumerosPrimos(numero);
        }
    }
}
