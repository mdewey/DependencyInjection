using System;

namespace DependencyInjection
{
    // sword, bowAndArrow, MagicMissle
    public interface IWeapon
    {
        void DoDamage();
    }

    public class Sword : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Swinging Sword");
            
        }
    }

    public class BowAndArrow : IWeapon
    {
        public void DoDamage()
        {
           Console.WriteLine("Shooting Bow");
           
        }
    }

    public class MagicMissle : IWeapon
    {
        public void DoDamage()
        {
         Console.WriteLine("Firing at darkness");
        }
    }

}