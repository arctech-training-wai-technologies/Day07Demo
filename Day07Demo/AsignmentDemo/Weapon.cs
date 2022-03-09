using Day07Demo.AsignmentDemo.Interfaces;

namespace Day07Demo
{
    public abstract class Weapon : IWeapon
    {
        int _magazineCapacity; 
        int _totalRemainingBullets;
        int _bulletsInsideWeapon;
        
        public Weapon(int magazineCapacity, int bulletCount)
        {
            _magazineCapacity = magazineCapacity;
            _totalRemainingBullets = bulletCount;
            _bulletsInsideWeapon = _magazineCapacity;
        }

        public abstract void HideWeapon();
        public abstract void ShowWeapon();

        public virtual void Reload()
        {
            _bulletsInsideWeapon = _magazineCapacity;
        }

        public virtual void Shoot()
        {
            _totalRemainingBullets -= 1;
            Console.WriteLine($"Weapon has been shot with bullets {1}");
        }

        public virtual void Display()
        {
            Console.WriteLine($"Weapon: MagazineCapacity: {_magazineCapacity}, RemainingBullets: {_totalRemainingBullets}");
        }
    }
}
