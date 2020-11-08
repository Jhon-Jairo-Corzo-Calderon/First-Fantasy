using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class Potion : Items
    {
        public Potion(int amount)
        {
            Amount = amount;
            Name = "Potion";
            Description = "When used, heal 20% of missing life.";
        }
    }
}
