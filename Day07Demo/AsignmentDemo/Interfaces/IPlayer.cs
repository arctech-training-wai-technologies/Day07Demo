namespace Day07Demo.AsignmentDemo.Interfaces
{
    public interface IPlayer
    {
        public void GetShot(int damage);
        public void Move(char direction); // N, E, W, S        
    }
}
