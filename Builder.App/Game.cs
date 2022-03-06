using System;
using Builder.Lib.Armors;
using Builder.Lib.Creators;
using Builder.Lib.Heroes;
using Builder.Lib.Inventories;
using Builder.Lib.Weapons;

namespace Builder.App
{
    public static class Game
    {
        private static Armor CreateArmor()
        {
            Console.WriteLine("Выберите защиту: ");
            Console.WriteLine("1. Лёгкая");
            Console.WriteLine("2. Тяжёлая");
            var selectArmor = Console.ReadLine();
            
            return selectArmor switch
            {
                "1" => new SoftArmor(),
                "2" => new HeavyArmor(),
                _ => null
            };
        }

        private static Weapon CreateWeapon()
        {
            Console.WriteLine("Выберите оружие: ");
            Console.WriteLine("1. Посох");
            Console.WriteLine("2. Топор");
            var selectWeapon = Console.ReadLine();
            
            return selectWeapon switch
            {
                "1" => new Staff(),
                "2" => new Ax(),
                _ => null
            };
        }

        private static ICreator CreateCreator()
        {
            Console.WriteLine("Выберите тип персонажа: ");
            Console.WriteLine("1. Маг");
            Console.WriteLine("2. Варвар");
            var selectHero = Console.ReadLine();
            
            return selectHero switch
            {
                "1" => new CreateMage(),
                "2" => new CreateBarbarian(),
                _ => null
            };
        }

        private static IInventory CreateInventory()
        {
            Console.WriteLine("Выберите тип инвенторя: ");
            Console.WriteLine("1. Оружие");
            Console.WriteLine("2. Защита");
            var select = Console.ReadLine();
            return select switch
            {
                "1" => CreateWeapon(),
                "2" => CreateArmor(),
                _ => null
            };
        }

        public static Hero CreateHero()
        {
            var creator = CreateCreator();
            var armor = CreateArmor();
            var weapon = CreateWeapon();
            var hero = creator.Create(armor, weapon);
            
            Console.Write("Хотите добавить орижие или защиту в инвентарь?");
            var select = Console.ReadLine();
            if (select?.ToUpper() == "Y")
            {
                hero.Inventories.Add(CreateInventory());
            }

            return hero;
        }

        public static void ShowHero(Hero hero)
        {
            Console.WriteLine("=== HERO ===");
            Console.WriteLine($"Health: {hero.Health}");
            Console.WriteLine($"Weapon: {hero.Weapon.GetType().Name}");
            Console.WriteLine($"Armor: {hero.Armor.GetType().Name}");
            foreach (var inventory in hero.Inventories)
            {
                ShowInventory(inventory);
            }
            Console.WriteLine("=== === ===");
        }

        public static void ShowInventory(IInventory inventory)
        {
            Console.WriteLine("== Inventory ==");
            Console.WriteLine($"Type: {inventory.GetType().Name}");
            Console.WriteLine("== == ==");
        }
    }
}