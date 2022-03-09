namespace Day07Demo
{
    public class Ak47 : Weapon
    {
        ConsoleColor _barellColor;
        bool _allowSilencer;

        public Ak47(int magazineCapacity, int bulletCount, ConsoleColor barellColor) : base(magazineCapacity, bulletCount)
        {
            _barellColor = barellColor;
            _allowSilencer = true;
        }
        
        public override void Shoot()
        {
            for (int i = 1; i <= 10; i++)
                base.Shoot();
        }

        public override void HideWeapon()
        {
            Console.WriteLine("Ak47: Hiding...");
        }

        public override void ShowWeapon()
        {
            Console.WriteLine("Ak47: Showing...");
        }

        public override void Display()
        {
            Console.BackgroundColor = _barellColor;
            base.Display();
            Console.WriteLine($"Ak47: Silencer Allowed?: {_allowSilencer}");
            Console.ResetColor();
        }
    }
}
