﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Weapons
{
    public class AngelStaff : Weapon
    {
        public AngelStaff()
        {
            Name = "Angel Staff";
            Amount = 1;
            Description = "The gods blessed you with the angel staff, with it, you'll be able to summon an angel that will damage enemies for you.";
            Damage = 45;
            AtackSpeed = 1.2;
            Range = 45;
        }

        public static string WDescription()
        {
            return "The gods blessed you with the angel staff, with it, you'll be able to summon" +
               "\n" + "an angel that will damage enemies for you.";
        }
    }
}
