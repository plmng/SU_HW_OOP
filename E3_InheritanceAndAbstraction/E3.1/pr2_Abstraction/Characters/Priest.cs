namespace pr2_Abstraction.Characters
{
    using Interfaces;

    public class Priest: Character, IHeal
    {
        public Priest() : base(125, 200, 100)
        {
        }
       
        public override void Attack(Character target)
        {

            target.Health -= this.Damage;
            this.Mana -= 100;
            this.Health += this.Damage/10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
