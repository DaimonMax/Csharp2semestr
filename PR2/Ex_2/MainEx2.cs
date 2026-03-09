using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PR2.Ex_2
{
    internal class MainEx2
    {
        public static void RunEx2()
        {
            Player.DamageTaken += UIHealthBar.CurrentHealth;
            Player.DamageTaken += SoundSystem.PlaySound;
            Player.DamageTaken += AchievementSystem.CheckAchievements;
            Player.DamageTaken += GameLogger.LogDamage;

            Player.TakeDamage(-10);
            Player.TakeDamage(0);
            Player.TakeDamage(10);
            Player.TakeDamage(20);
            Player.TakeDamage(30);
            Player.TakeDamage(40);
            Player.TakeDamage(50);
            Player.TakeDamage(60);
            Player.TakeDamage(70);
            Player.TakeDamage(80);
            Player.TakeDamage(90);
            Player.TakeDamage(100);
        }
    }
}

