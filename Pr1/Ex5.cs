using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Ex5
    {
        internal static void RunEx5()
        {
            LogHandler = message => Console.WriteLine($"{message}");
            Log("Log!");
            LogHandler = message => Console.WriteLine($"{message.ToUpper()}");
            Log("Log!");
            Console.WriteLine("---------------------------------------------------");
        }

        private static Action<string>? LogHandler;
        private static void Log(string message)
        {
            if (LogHandler != null)
            {
                LogHandler.Invoke(message);
            }
            else
            {
                Console.WriteLine("LogHandler is null!");
            }
        }
    }
}
