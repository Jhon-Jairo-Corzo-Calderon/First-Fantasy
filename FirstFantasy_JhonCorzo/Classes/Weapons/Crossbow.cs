using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class Crossbow : Weapon
    {
        Crossbow()
        {
            damage = 80;
            atackSpeed = 2.5;
            range = 150; 
        }

        public override string Description()
        {
            return "This weapon has high atack speed, but lower damage than a bow.";
        }
    }
}
