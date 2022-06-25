using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Domain.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// constantes
        /// </summary>
        public const double PI = 3.1415926535897931;

        /// <summary>
        /// atributos
        /// </summary>
        public double Radio { get; private set; }

        internal Circle(double radio)
        {
            if(radio < 0)
                throw new ArgumentOutOfRangeException("radio debe ser mayor 0 igual a 0");

            this.Radio = radio;
        }

        public override double CalculateArea()
        {
            return PI * Math.Pow(Radio, 2);
        }
    }
}
