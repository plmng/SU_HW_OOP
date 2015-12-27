namespace pr2_Abstraction.Characters
{
    public class Mage: Character
    {
        public Mage()
            : base(100, 300, 75)
        {
        }

        //But when the Mage attacks, he uses 100 mana and deals twice his default damage.         
        public override void Attack(Character target)
        {
            target.Health -= 2*this.Damage;
            this.Mana -= 100;
        }
    }
}
