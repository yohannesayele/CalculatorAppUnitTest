using MyCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplicationUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 6.4, y = 2.5;
            Console.WriteLine("x value is " + x);
            Console.WriteLine("y value is " + y);
            Calcuator cal = new Calcuator();
            Console.WriteLine("Addition of x and y is " + cal.Addition(x, y));
            Console.WriteLine("Substraction of x and y is " + cal.Substraction(x, y));
            Console.WriteLine("Multiplication of x and y is " + cal.Multiplication(x, y));
            Console.WriteLine("Division of x and y is " + cal.Division(x, y));
            Console.WriteLine("Modulos  of x and y is " + cal.Modulos(x, y));
        }
    }
}
