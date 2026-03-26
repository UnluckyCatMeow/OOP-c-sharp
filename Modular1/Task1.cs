using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular1
{
    public delegate string TextOperation(string input);
    public static class Task1
    {
        public static void Run()
        {
            string inputFile = "textPD25.txt";
            string outputFile = "resultPD25.txt";

            File.WriteAllText(outputFile, string.Empty);

            TextOperation toUpper = (text) => text.ToUpper();
            TextOperation countChars = (text) => $"Кількість символів: {text.Length}";
            TextOperation countWords = (text) => {
                int count = text.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                return $"Кількість слів: {count}";
            };

            Console.WriteLine("Обробка файлу...");

            ProcessFile(inputFile, outputFile, toUpper);
            ProcessFile(inputFile, outputFile, countChars);
            ProcessFile(inputFile, outputFile, countWords);

            Console.WriteLine($"Результати записані у {outputFile}");
        }
        public static void ProcessFile(string sourcePath, string destPath, TextOperation operation)
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(destPath))
            {
                sw.WriteLine($"Виконання операції: {operation.Method.Name}");
                foreach (string line in lines)
                {
                    string result = operation(line);
                    sw.WriteLine(result);
                }
                sw.WriteLine();
            }
        }
    }
}
