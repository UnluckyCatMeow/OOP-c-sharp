using Gendelyck;
using System.Security.Cryptography.X509Certificates;

namespace Gendelyk
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Вітаємо в нашому Генделику!)");
            
            Restaurant res = new Restaurant();
            res.Run();
            

        }
   
    }
}

