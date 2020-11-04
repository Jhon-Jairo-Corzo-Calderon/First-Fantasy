using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public abstract class Weapon
    {
        public int damage = 0;
        public double atackSpeed = 0;
        public int range = 0; //Distance in pixels

        public static int CritChance()
        {
            Random rnm = new Random();

            int critChance = rnm.Next(0,8);

            return critChance;
        }

        public List<string> BaseStats()
        {
            List<string> stats = new List<string>();

            if (damage != 0)
            {
                stats.Add(damage.ToString());
                stats.Add(range.ToString());
                stats.Add(atackSpeed.ToString());

                return stats;
            }
            else
            {
                throw new System.Exception("The class is not initialized.");
            }
        }

        public virtual string Description()
        {
            return "";
        }
    }
}
