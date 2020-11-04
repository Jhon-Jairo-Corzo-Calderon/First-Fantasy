using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class AngelStaff : Weapon
    {
        AngelStaff()
        {
            damage = 45;
            atackSpeed = 1.2;
            range = 45;
        }

        public override string Description()
        {
            return "The gods blessed you with the angel staff, with it, you'll be able to summon" +
               "\n"+ "an angel that will damage enemies for you.";
        }
    }
}
