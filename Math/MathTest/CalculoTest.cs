using Math.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MathTest
{
    [TestClass]
    public class CalculoTest
    {
        [TestMethod]
        public void TestarMetodoCalcularDivisoresEDivisoresPrimos()
        {
            var calculo = new Calculo();

            var resp = calculo.CalcularDivisoresEDivisoresPrimos(40);

            Assert.IsNotNull(resp.Divisores);
            Assert.IsNotNull(resp.DivisoresPrimos);
            Assert.AreEqual(1, resp.Divisores.FirstOrDefault());
            Assert.AreEqual(40, resp.Divisores.LastOrDefault());
            Assert.AreEqual(2, resp.DivisoresPrimos.FirstOrDefault());
            Assert.AreEqual(5, resp.DivisoresPrimos.LastOrDefault());
        }
    }
}
