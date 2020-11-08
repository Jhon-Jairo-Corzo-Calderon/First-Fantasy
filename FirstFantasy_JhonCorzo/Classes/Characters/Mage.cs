using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
    public class Mage : Characters
    {
        public Mage()
        {
            Level = 1;
            CharClass = "Mage";
            Health = 550;
            Damage = 28;
        }

        public static string Description()
        {
            string mage = "With this class you will be able to deal lots of physical damage, through your spells, but you have to be " +
                "careful with the amount of damage you recieve, because your life is the lowest of all the classes.";


            return mage;
        }

        public  string CharPhrase()
        {
            string phrase1 = "Study, study and practice, those are the only 3 things you need to become a powerful mage";
            return phrase1;
        }

    }
}
