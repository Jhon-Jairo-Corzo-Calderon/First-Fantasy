using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes
{
    public class Weapon : Items
    {
        private int damage = 0;
        private double atackSpeed = 0;
        private int range = 0; //Distance in pixels

        public int Damage { get => damage; set => damage = value; }
        public double AtackSpeed { get => atackSpeed; set => atackSpeed = value; }
        public int Range { get => range; set => range = value; }

        public int CritChance()
        {
            Random rnm = new Random();

            int critChance = rnm.Next(0,8);

            return critChance;
        }

    }
}
