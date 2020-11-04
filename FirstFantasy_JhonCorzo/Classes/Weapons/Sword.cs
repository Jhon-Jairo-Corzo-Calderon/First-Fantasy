using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class Sword : Weapon
    {
        Sword()
        {
            damage = 30;
            atackSpeed = 1.0;
            range = 40;
        }
        public override string Description()
        {
            return "The typical sword.";
        }
    }
}
