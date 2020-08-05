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

        [TestMethod]
        public void TestarMetodoCalcularDivisores()
        {
            var calculo = new Calculo();

            var resp = calculo.CalcularDivisores(20);

            Assert.IsNotNull(resp);
            Assert.AreEqual(1, resp.FirstOrDefault());
            Assert.AreEqual(20, resp.LastOrDefault());
        }

        [TestMethod]
        public void TestarMetodoIndicaDivisorPrimo()
        {
            var calculo = new Calculo();

            var resp = calculo.IndicaDivisorPrimo(5);

            Assert.IsNotNull(resp);
            Assert.IsTrue(resp);
        }

        [TestMethod]
        public void TestarMetodoIndicaDivisorPrimoComValorNaoPrimo()
        {
            var calculo = new Calculo();

            var resp = calculo.IndicaDivisorPrimo(10);

            Assert.IsNotNull(resp);
            Assert.IsFalse(resp);
        }
    }
}
