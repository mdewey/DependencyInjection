namespace DependencyInjection
{
    public class Wizard: Warrior
    {
        public Wizard() :base(new MagicMissle())
        {
            
        }
    }
}