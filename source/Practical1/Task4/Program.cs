using System;

namespace Task4
{
    public class Program
    {
        public static bool IsValidTriangle(double a, double b, double c)
        {
            if (a <= 0 ||  b <= 0 || c <= 0)
                return false;

            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("сторони не утворюють трикутник");

            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("сторони не утворюють трикутник");

            double p = GetPerimeter(a, b, c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("сторони не утворюють трикутник");

            if (a == b && b == c)
                return "рівносторонній";

            if (a == b || b == c || a == c)
                return "рівнобедрений";

            double a2 = a * a, b2 = b * b, c2 = c * c;
            if (Math.Abs(a2 + b2 - c2) < 1e-9 ||
                Math.Abs(a2 + c2 - b2) < 1e-9 ||
                Math.Abs(b2 + c2 - a2) < 1e-9)
                return "прямокутний";

            return "довільний";
        }

        public static void Main()
        {
            double a = 3, b = 4, c = 5;

            try
            {
                Console.WriteLine($"Периметр: {GetPerimeter(a, b, c)}");
                Console.WriteLine($"Площа: {GetArea(a, b, c):F2}");
                Console.WriteLine($"Тип: {GetTriangleType(a, b, c)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}