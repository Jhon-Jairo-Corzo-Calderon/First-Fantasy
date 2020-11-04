using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class Shield : Items
    {
        public Shield()
        {
            amount = 1;
            name = "Shield";
        }
        public override string Description()
        {
            return "Increase Defense.";
        }

    }
}
