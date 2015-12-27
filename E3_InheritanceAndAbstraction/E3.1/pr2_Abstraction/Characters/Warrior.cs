namespace pr2_Abstraction.Characters
{
    public class Warrior: Character
    {
        public Warrior() : base(300, 0, 120)
        {
        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
        }
    }
}
