using Day07Demo.AsignmentDemo.Interfaces;

namespace Day07Demo
{
    public class Hero : Player, IHero
    {
        public Hero(string name, char direction) : base(name, direction)
        {
        }

        public void Display()
        {
            Console.WriteLine($"Hero : {_name}, health={_health}, facing direction={_direction}");
        }

        public void GetShot(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
                Console.WriteLine($"Hero has died... :)");
            }
        }

        public void Move(char direction)
        {
            Console.Write($"Hero Originally facing: {_direction}");
            _direction = direction;
            Console.WriteLine($"Hero Now facing: {_direction}");
        }

        public void ShootEnemy(IEnemy enemy, int damage)
        {
            Console.Write($"Hero About to Shooting Enemy. ");
            Display();
            enemy.Display();

            enemy.GetShot(damage);

            Console.Write($"After Shooting Enemy. ");
            enemy.Display();
        }
    }
}
