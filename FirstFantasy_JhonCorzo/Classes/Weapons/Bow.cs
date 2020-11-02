using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class Bow : Weapon
    {
        Bow()
        {
            damage = 128;
            atackSpeed = 1.5;
            range = 150;
        }

        public string Description()
        {
            return "High damage, but lower atack speed than the Crossbow.";
        }
    }
}
