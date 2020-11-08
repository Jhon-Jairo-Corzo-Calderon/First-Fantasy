using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class DamagePotion : Items
    {
        public DamagePotion(int amount)
        {
            Amount = amount;
            Name = "DamagePotion";
            Description = "When used, increase damage for 5 minutes.";
        }

    }
}
