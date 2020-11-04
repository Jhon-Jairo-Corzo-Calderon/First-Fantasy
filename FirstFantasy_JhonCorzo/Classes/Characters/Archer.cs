using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
    public class Archer : Characters
    {
        Archer()
        {      
            health = 600;
            damage = 20;    
        }

        public override string Description()
        {
            string archer = "With this class you will be able to deal lots of physical damage, through arrows, but you will " +
                "have to be careful with the amount of damage you recieve, because your life is pretty low.";

            return archer;
        }

        public  string CharPhrase()
        {
            string phrase1 = "One arrow, one kill.";
            return phrase1;
        }
    }
}
