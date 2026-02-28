using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Ex4
    {
        internal static void RunEx4()
        {
            // 1
            operation = Add;
            double result = operation(4, 5);
            Console.WriteLine(result);

            operation = Substract;
            result = operation(4, 5);
            Console.WriteLine(result);

            operation = Multiply;
            result = operation(4, 5);
            Console.WriteLine(result);

            try
            {
                operation = Divide;
                result = operation(4, 5);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // 2
            Console.WriteLine("===================================================");
            List<String> names = ["Alice", "Bob", "Charlie", "David", "Eve", "Elena"];
            char letter = 'E';
            var students = names.FindAll(name => name.StartsWith(letter));
            Console.WriteLine($"Students: '{letter}':");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------");
        }

        private static Func<double, double, double>? operation;

        private static double Add(double a, double b) => a + b;
        private static double Substract(double a, double b) => a - b;
        private static double Multiply(double a, double b) => a * b;
        private static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }
}
