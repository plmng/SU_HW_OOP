namespace TheSlum.Items
{
    public class Injection: Bonus
    {
        private const int DefaultHealthEffect = 200;
        private const int DefaultDefenceEffect = 0;
        private const int DefaultAttackEffect = 0;

        public Injection(string id)
            : base(id, DefaultHealthEffect, DefaultDefenceEffect, DefaultAttackEffect)
        {
            this.Countdown = 3;
            this.HasTimedOut = true;
            this.Timeout = 3;
        }
    }
}
