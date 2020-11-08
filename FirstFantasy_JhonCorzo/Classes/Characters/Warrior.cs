using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
    public class Warrior : Characters
    {
        public Warrior()
        {
            Health = 1000;
            Damage = 10;
            Level = 1;
            CharClass = "Warrior";
        }

        public static string Description()
        {
            string warrior = "With this class you will be able to tank and deal damage, but focusing on the tank role.";

            return warrior;
        }

    }
}
