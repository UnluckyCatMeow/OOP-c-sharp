namespace Pr1
{
    public class ShowConsole
    {
        public static void ShowCollection<T>(ICollection<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item}, ");
            }
        }
        public static void ShowAll()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("---------Перше завдання--------");

            Console.WriteLine("Калькулятор чисел:");
            Calculator calculator = new Calculator();

            MathOperation add = calculator.Add;
            double result = add(23.0, 3.0);
            Console.WriteLine($"Результат додавання: {result}");

            add = calculator.Subtract;
            result = add(23.0, 3.0);
            Console.WriteLine($"Результат віднімання: {result}");

            add = calculator.Divide;
            result = add(23.0, 3.0);
            Console.WriteLine($"Результат множення: {result}");

            add = calculator.Multiply;
            result = add(23.0, 3.0);
            Console.WriteLine($"Результат ділення: {result}");

            Console.WriteLine("---------Друге завдання--------");

            Multicasting multicasting = new Multicasting();
            multicasting.Example();

            Console.WriteLine("---------Третє завдання--------");
            Console.WriteLine("Гарні числа:");
            Filter filter = new Filter();
            int[] nums = GetRandomArray(10, -23, 23);
            FilterPredicate predicate = number => number % 2 == 0;
            filter.FilterArray(nums, predicate);
            Console.WriteLine("Гарні числа:");
            FilterPredicate predicate2 = number => number > 5;
            filter.FilterArray(nums, predicate2);
            Console.WriteLine("Гарні числа:");
            FilterPredicate predicate3 = number => number % 2 != 0;
            filter.FilterArray(nums, predicate3);

            Console.WriteLine("---------Четверте завдання--------");
            Standart.Run();

            Console.WriteLine("\n---------П'яте завдання--------");
            Logger.LogHandler = (msg) => Console.WriteLine(msg);
            Logger.Log("Мені це важко далось");
            Logger.LogHandler = (msg) => Console.WriteLine(msg.ToUpper());
            Logger.Log("Мені це важко далось");

            Console.WriteLine("\n---------Шосте завдання--------");

            Dynamic.Validator passwordValidator = Dynamic.GetValidator(8);
            Dynamic.Validator loginValidator = Dynamic.GetValidator(5);

            Console.Write("Введіть новий пароль: ");
            string password = Console.ReadLine();
            if (!passwordValidator(password))
            {
                Console.WriteLine("Пароль має бути більшим аніж 8 символів");
            }
            else
            {
                Console.WriteLine("Пароль збережено!");
            }
            Console.WriteLine();

            Console.Write("Введіть новий логін: ");
            string login = Console.ReadLine();
            if (!loginValidator(login))
            {
                Console.WriteLine("Логін має бути більшим аніж 5 символів");
            }
            else
            {
                Console.WriteLine("Логін збережено!");
            }

        }
        static int[] GetRandomArray(int size, int min, int max) //генератор рандомних чисел
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }
    }
}
            //назва делегата?.Invoke(аргументи)