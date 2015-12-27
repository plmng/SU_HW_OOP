namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Healer: Character, IHeal
    {
        private const int DefaultHealthPoints = 75;
        private const int DefaultDefencePoints = 50;
        private const int DefaultHealingPoints = 60;
        private const int DefaultRange = 6;

        public Healer(string id, int x, int y, Team team )
            : base(id, x, y, DefaultHealthPoints, DefaultDefencePoints, team, DefaultRange)
        {
            this.HealingPoints = DefaultHealingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets = from target in targetsList
                          where target.IsAlive && target.Team == this.Team && target != this
                          orderby target.HealthPoints
                          select target;
            var theTarget = targets.FirstOrDefault() as Character;
            return theTarget;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}
