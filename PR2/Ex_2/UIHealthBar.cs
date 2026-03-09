using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_2
{
    internal class UIHealthBar
    {
        public static void CurrentHealth(int damage, int healthPoint)
        {
            if (healthPoint < 0)
            {
                healthPoint = 0;
            }
            Console.WriteLine($"Current health: {healthPoint}");
        }
    }
}
