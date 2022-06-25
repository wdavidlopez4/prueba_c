using Prueba.Domain.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Domain
{
    public static class Factory
    {
        public static Figure BulidSquare(double altura, double @base)
        {
            return new Square(altura, @base);
        }

        public static Figure BuildCicle(double radio)
        {
            return new Circle(radio);
        }
    }
}
