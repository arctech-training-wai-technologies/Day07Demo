namespace Day07Demo.AsignmentDemo.Interfaces
{
    public interface IHero : IPlayer
    {
        public void ShootEnemy(IEnemy enemy, int damage); public void Display();
    }
}
