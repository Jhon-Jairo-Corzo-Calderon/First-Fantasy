using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class Hammer : Weapon
    {
        Hammer()
        {
            damage = 50;
            atackSpeed = 0.6;
            range = 40;
        }
        public string Description()
        {
            return "More damage than a sword, but with lower atack speed";
        }
    }
}
