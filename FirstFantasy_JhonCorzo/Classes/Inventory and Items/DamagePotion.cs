using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class DamagePotion : Items
    {
        public DamagePotion(int amount)
        {
            this.amount = amount;
            name = "DamagePotion";
        }

        public override string Description()
        {
            return "When used, increase damage for 5 minutes.";
        }
    }
}
