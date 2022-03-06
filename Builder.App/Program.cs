using System;
using Builder.Lib.Armors;
using Builder.Lib.Creators;
using Builder.Lib.Weapons;

namespace Builder.App
{
    internal static class Program
    {
        private static void Main()
        {
            var hero = Game.CreateHero();
            var enemy = Game.CreateHero();

            Game.ShowHero(hero);
            Game.ShowHero(enemy);
            
            hero.Attack(enemy);
            enemy.Attack(hero);
            
            Game.ShowHero(hero);
            Game.ShowHero(enemy);
        }
        
        
    }
}