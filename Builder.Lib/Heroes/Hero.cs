using System.Collections.Generic;
using Builder.Lib.Armors;
using Builder.Lib.Inventories;
using Builder.Lib.Weapons;

namespace Builder.Lib.Heroes
{
    public abstract class Hero
    {
        private int _health;
        public int Health
        {
            get => _health;
            set => _health = value < 0 ? 0 : value;
        }
        
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        
        public List<IInventory> Inventories { get; set; }

        public void Attack(Hero enemy)
        {
            if (Armor.Defense > 0)
            {
                Armor.Defense -= Weapon.Damage;
            }
            else
            {
                Health -= Weapon.Damage;
            }
        }
        
    }
}