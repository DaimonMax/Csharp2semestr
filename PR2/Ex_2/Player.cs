using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2.Ex_2
{
    internal class Player
    {
        private static int healthPoint = 100;
        public static event Action<int, int>? DamageTaken;

        public static void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                damage = 0;
            }
            healthPoint -= damage;
            Console.WriteLine($"Player took {damage} damage");
            DamageTaken?.Invoke(damage, healthPoint);
            if (healthPoint <= 0)
            {
                Respawn();
            }
        }

        private static void Respawn()
        {
            Console.WriteLine($"Rebirth!");
            healthPoint = 100;
            Console.WriteLine($"HP restored to {healthPoint}");
        }
    }
}
