namespace DependencyInjection
{
    public class Knight : Warrior
    {
        public Knight() : base(new Sword())
        {
            
        }
    }
}