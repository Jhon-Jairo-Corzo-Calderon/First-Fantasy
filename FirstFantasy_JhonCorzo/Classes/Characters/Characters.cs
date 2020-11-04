using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
     public abstract class Characters
    {
        private string name ="";
        private string genre = "";
        private int age;
        private int level;
        private int experience;

        //Stats
        public int health;
        public int damage;

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Age { get => age; set => age = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        
        public List<string> CharacterInfo()
        {
            List<string> info = new List<string>();

            if(name=="" || genre == "")
            {
                throw new InvalidOperationException();
            }
            else
            {             
                 string ageInf = age.ToString();
                 string levelInf = level.ToString();
                 string expInf = experience.ToString();

                info.Add(name);
                info.Add(genre);
                info.Add(ageInf);
                info.Add(levelInf);
                info.Add(expInf);               
            }

            return info;
        }

        public virtual string Description()
        {
            return "";
        }
    }
}
