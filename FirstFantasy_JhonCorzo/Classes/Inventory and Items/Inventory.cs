using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class Inventory
    {
        private List<Items> inventory = new List<Items>();

        public List<Items> AddToInvetory(Items items)
        {
            inventory.Add(items);
            return inventory;
        }

        public List<Items> DeleteItem(Items items)
        {
            if (inventory.Remove(items) == false)
                throw new System.Exception("This item doesn't exist.");
            
            return inventory;
        }

        public string InventoryText()
        {
            string text = "";
            foreach(Items items in inventory)
            {
                text += items.ItemInfo() + "\n";
            }

            return text;
        }
    }
}
