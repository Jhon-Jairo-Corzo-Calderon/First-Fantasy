using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class Crossbow : Weapon
    {
        public Crossbow()
        {
            Name = "Crossbow";
            Amount = 1;
            Description = "This weapon has high atack speed, but lower damage than a bow.";
            damage = 80;
            atackSpeed = 2.5;
            range = 150; 
        }

        public static string WDescription()
        {
            return "This weapon has high atack speed, but lower damage than a bow.";
        }
    }
}
