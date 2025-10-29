namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = GenerateRandomArray(10, 1, 100); //основний масив мій

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine();

            Console.WriteLine($"Сума: {GetSum(numbers)}");
            Console.WriteLine($"Середнє значення: {GetAverage(numbers)}");
            Console.WriteLine($"Мінімальне значення: {GetMin(numbers)}");
            Console.WriteLine($"Максимальне значення: {GetMax(numbers)}");
        }

        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] numbers = new int[size];

            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }

            return numbers;
        }
        public static int GetSum(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
        public static double GetAverage(int[] numbers)
        {
            return GetSum(numbers) / (double)numbers.Length;
        }
        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }
        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }

}
//int sum = 0;

//sum = sum + 5; ~ sum += 5;