using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class IronArrow : Items
    {
        public IronArrow(int amount)
        {
            this.amount = amount;
            name = "IronArrow";
        }

        public override string Description()
        {
            return "Ammo for bow or crossbow, increased damage than a wooden arrow.";
        }
    }
}
