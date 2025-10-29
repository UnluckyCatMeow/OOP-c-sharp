using System.ComponentModel.Design;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть число: ");
            int.TryParse(Console.ReadLine(),out int num); // це ми перевели строчку в інт, щоб в першому методі вводилось тільки число?
            Console.WriteLine(GetMessage(num));
        }
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
        public static string GetMessage(int number)
        {
            if (IsEven(number))
                return "Двері відкриваються!";
            else
                return "Двері зачинені...";

            //ctrl+k+d
        }
    }
}
