namespace Builder.Lib.Armors
{
    public abstract class Armor
    {
        private int _defense;
        public int Defense
        {
            get => _defense;
            set => _defense = value < 0 ? 0 : value;
        }
    }
}