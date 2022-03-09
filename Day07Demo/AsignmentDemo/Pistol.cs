namespace Day07Demo
{
    public class Pistol : Weapon
    {
        public Pistol(int magazineCapacity, int bulletCount) : base(magazineCapacity, bulletCount)
        {

        }

        public override void HideWeapon()
        {
            Console.WriteLine("Pistol: Hiding...");
        }

        public override void ShowWeapon()
        {
            Console.WriteLine("Pistol: Showing...");
        }
    }
}
