using System;
using System.Text;

namespace Task3
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть ваш вік: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int age))
            {
                string category = ClassifyAge(age);
                Console.WriteLine(category);
            }
            else
            {
                Console.WriteLine("Некоректне введення. Введіть ціле число.");
            }
        }

        public static string ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
                return "Нереальний вік";
            else if (age < 12)
                return "Ви дитина";
            else if (age >= 12 && age <= 17)
                return "Підліток";
            else if (age >= 17 && age <= 59)
                return "Дорослий";
            else
                return "Пенсіонер";
        }
    }
}
