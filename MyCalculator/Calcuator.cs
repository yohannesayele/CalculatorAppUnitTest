using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calcuator
    {   public double Addition(double x, double y)
        {
            double result;
            result = x + y;
            return result;
        }
        public double Substraction(double x, double y)
        {
            double result;
            result = Math.Round(( x - y),1);
            return result;
        }
        public  double Multiplication ( double x, double y)
        {
            double result;
            result= Math.Round((x *y),1);
            return result;

        }
        public double Division (double x, double y)
        {
            if (y == 0)
            {
                throw new Exception("Division by zero");
            }
            double result;
            result =Math.Round( (x / y),1);
            return result;

        }
        public double  Modulos (double x, double y)
        {
            double result;
            result = x % y;
            return result;
        }
        private bool IsNegative(double num)
        {
            bool mybool;
            if (num < 0)
            {
                mybool = true;
            }
            else
                mybool = false;

            return mybool;
        }
    }
}
