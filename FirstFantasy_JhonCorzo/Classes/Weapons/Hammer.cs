using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class Hammer : Weapon
    {
        public Hammer()
        {
            Name = "Hammer";
            Amount = 1;
            Description = "More damage than a sword, but with lower atack speed";
            Damage = 50;
            AtackSpeed = 0.6;
            Range = 40;
        }
        public static string WDescription()
        {
            return "More damage than a sword, but with lower atack speed";
        }
    }
}
