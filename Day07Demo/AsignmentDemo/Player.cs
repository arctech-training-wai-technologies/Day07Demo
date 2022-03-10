namespace Day07Demo
{
    public class Player
    {
        protected string _name;
        protected int _health;
        protected Direction _direction;

        public Player(string name, Direction startingDirection)
        {
            _health = 100;
            _name = name;
            _direction = startingDirection;
        }
    }
}
