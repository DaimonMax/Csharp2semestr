using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Ex1
    {
        internal static void RunEx1()
        {
            MathOperation operation = Add;
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
        }

        public delegate double MathOperation(double a, double b);

        static double Add(double a, double b) => a + b;
        static double Substract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }


    }
}
