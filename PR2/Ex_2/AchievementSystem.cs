using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_2
{
    internal class AchievementSystem
    {
        public static void CheckAchievements(int damage, int healthPoint)
        {
            if (healthPoint <= 50 && healthPoint > 0)
            {
                Console.WriteLine("Achievement -- Half Health");
            }

            if (healthPoint <= 0)
            {
                Console.WriteLine("Achievement -- Death");
            }
        }
    }
}
