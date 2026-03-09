using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_1
{
    internal class SecuritySystem
    {
        public static void TemperatureControl(int temperature)
        {
            if(temperature > 40)
            {
                Console.WriteLine("Overheating incoming!");
            }
            else if(temperature < 5)
            {
                Console.WriteLine("System is freezing!");
            }
            else {
                Console.WriteLine("Temperature is normal!");
            }
        }
    }
}
