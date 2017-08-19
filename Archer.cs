namespace DependencyInjection
{
    public class Archer : Warrior
    {
        public Archer():base(new BowAndArrow())
        {

        }
    }
}