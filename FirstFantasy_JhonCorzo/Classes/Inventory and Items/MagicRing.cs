using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class MagicRing : Items
    {
        public MagicRing( int amount)
        {
            Amount = amount;
            Name = "MagicRing";
            Description = "Increase Magic Damage.";
        }
        
    }
}
