using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class Shield : Items
    {
        public Shield(int amount)
        {
            Amount = amount;
            Name = "Shield";
            Description = "Increase Defense.";
        }

    }
}
