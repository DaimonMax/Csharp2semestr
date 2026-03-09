using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_1
{
    internal class AirConditioner
    {
        public static void AirConditionerTemperature(int temperature)
        {
            if (temperature < 17)
            {
                Console.WriteLine("Heating is on!");
            }
            else if (temperature > 17 && temperature < 25)
            {
                Console.WriteLine("Conditioner is off!");
            }
            else if (temperature > 25)
            {
                Console.WriteLine("Freezing is on!");
            }
            else
            {
                Console.WriteLine("Condition burned down!");
            }
        }
    }
}
