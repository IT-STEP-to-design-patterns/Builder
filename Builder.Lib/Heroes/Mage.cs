using System.Collections.Generic;
using Builder.Lib.Inventories;

namespace Builder.Lib.Heroes
{
    public class Mage : Hero
    {
        public Mage()
        {
            Health = 100;
            Inventories = new List<IInventory>();
        }
    }
}