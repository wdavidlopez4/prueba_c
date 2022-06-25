using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Domain.Figures
{
    public class Square : Figure
    {
        public double Base { get; private set; }

        public double Altura { get; private set; }

        internal Square(double altura, double @base) : base()
        {
            if (altura < 0)
                throw new ArgumentException("altura debe ser mayor o igual a 0");
            else if(@base < 0)
                throw new ArgumentException("base debe ser mayor o igual a 0");

            Altura = altura;
            Base = @base;
        }

        public override double CalculateArea()
        {
            return Altura * Base;
        }
    }
}
