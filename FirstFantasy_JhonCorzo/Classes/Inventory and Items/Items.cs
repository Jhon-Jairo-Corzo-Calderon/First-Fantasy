using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_JhonCorzo.Classes.Inventory_and_Items
{
    public class Items
    {
        public int amount;
        public string name;

        public virtual string Description()
        {
            return "";
        }

        public string ItemInfo()
        {
            string sAmount = amount.ToString();
            string itemInfo = name + " " + sAmount;

            return itemInfo;
        }
    }
}
