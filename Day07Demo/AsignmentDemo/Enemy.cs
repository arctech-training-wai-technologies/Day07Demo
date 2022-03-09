using Day07Demo.AsignmentDemo.Interfaces;

namespace Day07Demo
{
    public class Enemy : Player, IEnemy
    {
        public Enemy(string name, char direction) : base(name, direction)
        {
        }

        public void Display()
        {
            Console.WriteLine($"Enemy: {_name}, health={_health}, facing direction={_direction}");
        }

        public void GetShot(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
                Console.WriteLine($"Enemy has died... :)");
            }
        }

        public void Move(char direction)
        {
            Console.Write($"Enemy Originally facing: {_direction}");
            _direction = direction;
            Console.WriteLine($"Enemy Now facing: {_direction}");
        }

        public void ShootHero(IHero hero, int damage)
        {
            Console.Write($"About to Shooting hero. ");
            hero.Display();

            hero.GetShot(damage);

            Console.Write($"After Shooting hero. ");
            hero.Display();
        }
    }
}
