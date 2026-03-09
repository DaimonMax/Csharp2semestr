using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_1
{
    internal class MainEx1
    {
        public static void RunEx1()
        {
            TemperatureDatchik.TemperatureChanged += Display.ShowTemperature;
            TemperatureDatchik.TemperatureChanged += AirConditioner.AirConditionerTemperature;
            TemperatureDatchik.TemperatureChanged += SecuritySystem.TemperatureControl;

            TemperatureDatchik.ChangeTemperature(45);
            TemperatureDatchik.ChangeTemperature(200);
            TemperatureDatchik.ChangeTemperature(-10);
            TemperatureDatchik.ChangeTemperature(20);
            Console.WriteLine("==============================================================");
        }
    }
}
