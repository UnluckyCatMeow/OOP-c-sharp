using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Pr1
{
    public delegate double MathOperation(double x, double y);
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Дiлення на 0 неможливе, введіть інше число");
            }
            return a / b;
        }
    }
}
