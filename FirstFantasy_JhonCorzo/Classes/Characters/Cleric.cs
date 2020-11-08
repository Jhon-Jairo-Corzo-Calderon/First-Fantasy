using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
    public class Cleric : Characters
    {
        public Cleric()
        {
            Health = 450;
            Damage = 10;
            Level = 1;
            CharClass = "Cleric";
        }

        public static string Description()
        {
            string cleric = "With this class you will be able to help your teammates, thanks to the blessing of the gods" +
                ", you'll be able to heal yourself or any ally.";

            return cleric;
        }


    }
}
