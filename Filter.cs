using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public delegate bool FilterPredicate(int filterPredicate);
    public class Filter
    {
        public void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (var number in numbers) //number це одна змінна,numbers-колекція
            {
                if (predicate(number))
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
        }
    }
}
//  MathOperation add = calculator.Add;
//double result = add(23.0, 3.0);