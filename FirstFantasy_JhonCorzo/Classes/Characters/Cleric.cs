using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
    public class Cleric : Characters
    {
        Cleric()
        {
            health = 450;
            damage = 10;
        }

        public override string Description()
        {
            string cleric = "With this class you will be able to help your teammates, thanks to the blessing of the gods" +
                ", you'll be able to heal yourself or any ally.";

            return cleric;
        }

        public  string CharPhrase()
        {
            string phrase1 = "The gods will decide my destiny.";
            return phrase1;
        }

    }
}
