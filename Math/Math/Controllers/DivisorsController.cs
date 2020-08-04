using Math.Rules;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Math.Controllers
{
    public class DivisorsController : Controller
    {
        [Route("Divisors/CalcularNumerosDivisores")]
        [HttpGet]
        public List<double> CalcularNumerosDivisores(double numero)
        {
            return new Divisor().CalcularDivisores(numero);
        }
    }
}
