namespace WarriorFightToTheDeath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();
            battle.StartFight(new Thor(), new Hulk());
        }
    }
}
