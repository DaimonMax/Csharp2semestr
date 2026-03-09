using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_1
{
    internal class TemperatureDatchik
    {
        private static int _temperature;

        public static event Action<int>? TemperatureChanged;

        public static void ChangeTemperature(int temperature)
        {
            _temperature = temperature;
            Console.WriteLine($"Temperature changed to: {temperature}°C");

            TemperatureChanged?.Invoke(temperature);
        }
    }
}
