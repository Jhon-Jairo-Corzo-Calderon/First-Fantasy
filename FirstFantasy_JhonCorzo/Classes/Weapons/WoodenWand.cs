using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class WoodenWand : Weapon
    {
        public WoodenWand()
        {
            Name = "Wooden Wand";
            Amount = 1;
            Description = "Throug this wand, you'll be able to do any basic spell, but with a very low atack speed.";
            damage = 135;
            atackSpeed = 0.5;
            range = 170;
        }
        public static string WDescription()
        {
            return "Throug this wand, you'll be able to do any basic spell, but with a very low atack speed.";
        }
    }
}
