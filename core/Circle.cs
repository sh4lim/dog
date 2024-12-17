using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classnasledovaniye1.core
{
    internal class Circle : Shape
    {
        public override double CalculateArea()
        {
            Console.WriteLine("Найти площадь круга.\nВведите радиус: ");
            double a = double.Parse(Console.ReadLine());

            double result = 3.14 * (a*a);
            Console.WriteLine("Площадь вашего круга: " + result);
            return result;
        }
    }
}
