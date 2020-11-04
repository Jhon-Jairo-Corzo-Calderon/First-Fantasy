using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
    public class Warrior : Characters
    {
        Warrior()
        {
            health = 1000;
            damage = 10;
        }

        public override string Description()
        {
            string warrior = "With this class you will be able to tank and deal damage, but focusing on the tank role.";

            return warrior;
        }

        public  string CharPhrase()
        {
            string phrase1 = "Belive in your own strenght.";
            return phrase1;
        }
    }
}
