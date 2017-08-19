namespace DependencyInjection
{
    public abstract class Warrior : IAttacker
    {
        public string Name { get; set; }

        public int Health { get; set; }
        public int Mana { get; set; }

        public string Rank { get; set; }

        public IWeapon Weapon { get; set; }


        public Warrior(IWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public void Attack(){
            this.Weapon.DoDamage();
        }
    }
}