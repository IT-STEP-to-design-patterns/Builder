using Builder.Lib.Inventories;

namespace Builder.Lib.Weapons
{
    public abstract class Weapon : IInventory
    {
        public int Damage { get; set; }
    }
}