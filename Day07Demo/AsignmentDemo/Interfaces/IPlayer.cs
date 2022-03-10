namespace Day07Demo.AsignmentDemo.Interfaces
{
    public interface IPlayer
    {
        public void GetShot(int damage);
        public void Move(Direction direction); // N, E, W, S        
    }
}
