using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Ex3
    {
        internal static void RunEx3()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            FilterArray(array, IsEven);
            FilterArray(array, IsBiggerThan5);
            FilterArray(array, number => number % 2 != 0);
            Console.WriteLine("---------------------------------------------------");
        }

        private delegate bool FilterPredicate(int number);

        private static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine("===================================================");
        }

        private static bool IsEven(int number) => number % 2 == 0;

        private static bool IsBiggerThan5(int number) => number > 5;
    }
}
