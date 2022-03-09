using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Demo.AsignmentDemo
{
    // [S] [O] L I D
    // open closed principal
    // classes should be closed for modification and open for extension
    public class Bazooka : Weapon
    {
        public Bazooka(int magazineCapacity, int bulletCount) : base(magazineCapacity, bulletCount)
        {
        }

        public override void HideWeapon()
        {
            Console.WriteLine("Thowing Bazooka down on the ground!");
        }

        public override void ShowWeapon()
        {
            Console.WriteLine("Picking Bazooka from the ground!");
        }

        public override void Shoot()
        {
            base.Shoot();
            Console.WriteLine("WHOOOOSH BOOOOOOOM!!!!");
        }

        public override void Display()
        {
            Console.WriteLine("This is a beautiful bazooka!!");
        }
    }
}
