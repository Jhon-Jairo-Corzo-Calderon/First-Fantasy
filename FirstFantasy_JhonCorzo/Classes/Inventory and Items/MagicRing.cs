using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class MagicRing : Items
    {
        public MagicRing()
        {
            amount = 1;
            name = "MagicRing";
        }

        public override string Description()
        {
            return "Increase Magic Damage.";
        }
    }
}
