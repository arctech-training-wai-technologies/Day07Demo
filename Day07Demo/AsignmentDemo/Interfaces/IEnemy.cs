namespace Day07Demo.AsignmentDemo.Interfaces
{
    public interface IEnemy : IPlayer
    {
        public void ShootHero(IHero hero, int damage); public void Display();
    }
}
