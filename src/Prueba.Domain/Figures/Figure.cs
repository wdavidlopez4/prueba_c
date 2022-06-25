using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Domain.Figures
{
    public abstract class Figure
    {
        public double Area { get; protected set; }

        public abstract double CalculateArea();
    }
}
