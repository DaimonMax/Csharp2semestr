using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_2
{
    internal class SoundSystem
    {
        public static void PlaySound(int damage, int healthPoint)
        {
            Console.WriteLine("Damage taken sound!");

            if (healthPoint <= 20 && healthPoint > 0)
            {
                Console.WriteLine("Critical health sound!");
            }
        }
    }
}
