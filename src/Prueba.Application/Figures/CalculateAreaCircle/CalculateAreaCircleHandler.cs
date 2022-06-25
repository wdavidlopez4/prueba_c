using Prueba.Domain;
using Prueba.Domain.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Application.Figures.CalculateAreaCircle
{
    public class CalculateAreaCircleHandler
    {
        public double Handler(double radio)
        {
            double area;
            Circle circle;

            circle = (Circle) Factory.BuildCicle(radio);

            area = circle.CalculateArea();
            return area;
        }
    }
}
