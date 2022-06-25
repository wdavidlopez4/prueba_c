using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba.Application.Figures.CalculateAreaCircle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.UnitTest.Figures
{
    [TestClass]
    public class CalculateAreaCircle
    {
        [TestMethod]
        public void Handler()
        {
            CalculateAreaCircleHandler handler = new();
            double resp = handler.Handler(2);

            Assert.AreEqual(12.566370614359172, resp);
        }
    }
}
