using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class Bow : Weapon
    {
        public Bow()
        {
            Name = "Bow";
            Amount = 1;
            Description = "High damage, but lower atack speed than the Crossbow.";
            damage = 128;
            atackSpeed = 1.5;
            range = 150;
        }

        public static string WDescription()
        {
            return "High damage, but lower atack speed than the Crossbow.";
        }
    }
}
