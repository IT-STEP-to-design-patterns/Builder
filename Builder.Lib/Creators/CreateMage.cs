using Builder.Lib.Armors;
using Builder.Lib.Heroes;
using Builder.Lib.Weapons;

namespace Builder.Lib.Creators
{
    public class CreateMage : ICreator
    {
        public Hero Create(Armor armor, Weapon weapon)
        {
            return new Mage()
            {
                Armor = armor,
                Weapon = weapon
            };
        }
    }
}