namespace TheSlum.Items
{
    public class Pill: Bonus
    {
        private const int DefaultHealthEffect = 0;
        private const int DefaultDefenceEffect = 0;
        private const int DefaultAttackEffect = 100;

        public Pill(string id)
            : base(id, DefaultHealthEffect, DefaultDefenceEffect, DefaultAttackEffect)
        {
            this.Countdown = 1;
            this.HasTimedOut = true;
            this.Timeout = 1;
        }
    }
}
