using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public class Standart
    {
        public static Func<double, double, double>? Calculator;
        public static List<string> students = new List<string>();
        public static Predicate<string>? predicate;
        public static void Run()
        {
            students = new List<string>{
                "Анна", "Андрій", "Альоша", "Бобер", "Даша", "Алла"
            };
            predicate = msg => msg.StartsWith('А');
            List<string> filteredNames = students.FindAll(s => predicate(s)); //переглянуть
            Console.WriteLine("Студенти на букву А");
            ShowConsole.ShowCollection<string>(filteredNames);
        }
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