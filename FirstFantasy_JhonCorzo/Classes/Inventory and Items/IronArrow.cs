using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class IronArrow : Items
    {
        public IronArrow(int amount)
        {
            Amount = amount;
            Name = "IronArrow";
            Description = "Ammo for bow or crossbow, increased damage than a wooden arrow.";
        }
    }
}
