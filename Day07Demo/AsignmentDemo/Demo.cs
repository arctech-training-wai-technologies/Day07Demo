using Day07Demo.AsignmentDemo;
using Day07Demo.AsignmentDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Demo
{
    internal class Demo
    {
        public static void Test()
        {
            IWeapon weapon1 = new Pistol(6, 20);
            weapon1.Shoot();
            weapon1.Shoot();
            weapon1.Reload();
            weapon1.Display();

            IWeapon weapon2 = new Ak47(40, 240, ConsoleColor.Blue);
            weapon2.Shoot();
            weapon2.Reload();
            weapon2.Display();

            //IEnemy enemy = new Enemy("Rambo", 'N');
            //IHero hero = new Hero("Shaktiman", 'W');
            IEnemy enemy = new Enemy("Rambo", Direction.North);
            IHero hero = new Hero("Shaktiman", Direction.West);

            enemy.Display(); 
            hero.Display();
            enemy.Move(Direction.South);
            enemy.ShootHero(hero, 25);
            enemy.GetShot(10);
            enemy.Display();

            hero.Move(Direction.South);
            hero.ShootEnemy(enemy, 25);
            hero.GetShot(10);
            hero.Display();

            IWeapon version2Weapon = new Bazooka(1, 5);
            version2Weapon.Shoot();
            version2Weapon.Reload();
            version2Weapon.Display();
        }
    }
}
