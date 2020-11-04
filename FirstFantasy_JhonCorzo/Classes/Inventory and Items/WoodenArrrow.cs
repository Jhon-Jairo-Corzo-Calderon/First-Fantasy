using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class WoodenArrrow : Items
    {
        public WoodenArrrow(int amount)
        {
            this.amount = amount;
            name = "WoodenArrrow";
        }

        public override string Description()
        {
            return "Ammo for bow or crossbow, lower damage than a wooden arrow.";
        }
    }
}
