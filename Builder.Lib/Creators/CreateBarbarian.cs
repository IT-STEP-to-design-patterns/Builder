using Builder.Lib.Armors;
using Builder.Lib.Heroes;
using Builder.Lib.Weapons;

namespace Builder.Lib.Creators
{
    public class CreateBarbarian : ICreator
    {
        public Hero Create(Armor armor, Weapon weapon)
        {
            return new Barbarian()
            {
                Armor = armor,
                Weapon = weapon
            };
        }
    }
}