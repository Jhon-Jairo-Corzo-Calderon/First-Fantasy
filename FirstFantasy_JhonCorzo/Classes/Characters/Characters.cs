using FirstFantasy_JhonCorzo.Classes.Inventory_and_Items;
using FirstFantasy_JhonCorzo.Classes.Weapons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Characters
{
     public abstract class Characters
    {
        private string name ="";
        private string genre = "";
        private int age;
        private int level ;
        private string charClass;
        public BindingList<Items> inventory = new BindingList<Items>();

        //Stats
        private int health;
        private int damage;

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public string CharClass { get => charClass; set => charClass = value; }
        public int Age { get => age; set => age = value; }
        public int Level { get => level; set => level = value; }
        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }

  
        
        public string CharacterInfo()
        {           
            return "Name: "+name+".\n"+"Gender: "+genre+".\n"+"Age: "+age+".\n"+$"Level: {level}.\n" + $"Health: {health}.\n" + $"Damage: {damage}.";
        }

        

        public int Atack(Items weapon)
        {
            Weapon w = new Weapon();

            if(weapon.Name=="Angel Staff")
            {
                w = new AngelStaff();
            }
            else if (weapon.Name == "Bow")
            {
                w = new Bow();
            }
            else if (weapon.Name == "Crossbow")
            {
                w = new Crossbow();
            }
            else if (weapon.Name == "Hammer")
            {
                w = new Hammer();
            }
            else if (weapon.Name == "Sword")
            {
                w = new Sword();
            }
            else
            {
                w = new WoodenWand();
            }


            int critChance = w.CritChance();
            int wDamage = w.Damage() * critChance;

            int totalDamage = this.damage + wDamage;

            return totalDamage;
        }
        
        
    }
}
