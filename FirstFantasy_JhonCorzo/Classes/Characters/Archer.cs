using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
    public class Archer : Characters
    {
        public Archer()
        {      
            Health = 600;
            Damage = 20;
            Level = 1;
            CharClass = "Archer";
        }

        public static string Description()
        {
            string archer = "With this class you will be able to deal lots of physical damage, through arrows, but you will " +
                "have to be careful with the amount of damage you recieve, because your life is pretty low.";

            return archer;
        }

        public static  string CharPhrase()
        {
            string phrase1 = "One arrow, one kill.";
            return phrase1;
        }
    }
}
