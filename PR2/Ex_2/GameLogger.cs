using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_2
{
    internal class GameLogger
    {
        public static void LogDamage(int damage, int healthPoint)
        {
            if (healthPoint < 0)
            {
                healthPoint = 0;
            }
            Console.WriteLine($"Damage: {damage}, Current HP: {healthPoint}");
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
