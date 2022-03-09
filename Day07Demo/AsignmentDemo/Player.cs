namespace Day07Demo
{
    public class Player
    {
        protected string _name;
        protected int _health;
        protected char _direction;

        public Player(string name, char startingDirection)
        {
            _health = 100;
            _name = name;
            _direction = startingDirection;
        }
    }
}
