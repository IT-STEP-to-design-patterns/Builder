using System;
using Builder.Lib.Armors;
using Builder.Lib.Creators;
using Builder.Lib.Heroes;
using Builder.Lib.Weapons;

namespace Builder.App
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Выберите тип персонажа: ");
            Console.WriteLine("1. Маг");
            Console.WriteLine("2. Варвар");
            var selectHero = Console.ReadLine();
            
            Console.WriteLine("Выберите защиту: ");
            Console.WriteLine("1. Лёгкая");
            Console.WriteLine("2. Тяжёлая");
            var selectArmor = Console.ReadLine();
            
            Armor armor = selectArmor switch
            {
                "1" => new SoftArmor(),
                "2" => new HeavyArmor(),
                _ => null
            };

            Console.WriteLine("Выберите оружие: ");
            Console.WriteLine("1. Посох");
            Console.WriteLine("2. Топор");
            var selectWeapon = Console.ReadLine();
            
            Weapon weapon = selectWeapon switch
            {
                "1" => new Staff(),
                "2" => new Ax(),
                _ => null
            };

            IBuilder creator = selectHero switch
            {
                "1" => new CreateMage(),
                "2" => new CreateBarbarian(),
                _ => null
            };

            var hero = creator?.Create(armor, weapon);
        }
    }
}