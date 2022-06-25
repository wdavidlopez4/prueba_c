using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba.Application.Figures.CalculateAreaCircle;
using Prueba.Application.Figures.CalculateAreaSquare;

namespace Prueba.UnitTest.Figures
{
    [TestClass]
    public class CalculateAreaSquare
    {
        [TestMethod]
        public void Handler()
        {
            CalculateAreaSquareHandler handler = new();
            double resp = handler.Handler(2, 2);

            Assert.AreEqual(4, resp);
        }
    }
}