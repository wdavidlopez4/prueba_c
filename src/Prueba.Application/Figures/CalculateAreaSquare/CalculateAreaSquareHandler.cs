using Prueba.Domain;
using Prueba.Domain.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Application.Figures.CalculateAreaSquare
{
    public class CalculateAreaSquareHandler
    {
        public double Handler(double altura, double @base)
        {
            double area;
            Square square;

            square = (Square)Factory.BulidSquare(altura, @base);

            area = square.CalculateArea();
            return area;
        }

    }
}
