using Builder.Lib.Armors;
using Builder.Lib.Heroes;
using Builder.Lib.Weapons;

namespace Builder.Lib.Creators
{
    public interface IBuilder
    {
        public Hero Create(Armor armor, Weapon weapon);
    }
}