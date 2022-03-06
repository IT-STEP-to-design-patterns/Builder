using System.Collections.Generic;
using Builder.Lib.Inventories;

namespace Builder.Lib.Heroes
{
    public class Barbarian : Hero
    {
        public Barbarian()
        {
            Health = 150;
            Inventories = new List<IInventory>();
        }
    }
}