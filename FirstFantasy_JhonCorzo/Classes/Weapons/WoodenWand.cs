using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class WoodenWand : Weapon
    {
        WoodenWand()
        {
            damage = 135;
            atackSpeed = 0.5;
            range = 170;
        }
        public override string Description()
        {
            return "Throug this wand, you'll be able to do any basic spell, but with a very low atack speed.";
        }
    }
}
