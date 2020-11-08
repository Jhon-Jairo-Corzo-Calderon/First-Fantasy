using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class Sword : Weapon
    {
        public Sword()
        {
            Name = "Sword";
            Amount = 1;
            Description = "The typical sword.";
            damage = 30;
            atackSpeed = 1.0;
            range = 40;
        }
        public static string WDescription()
        {
            return "The typical sword.";
        }
    }
}
