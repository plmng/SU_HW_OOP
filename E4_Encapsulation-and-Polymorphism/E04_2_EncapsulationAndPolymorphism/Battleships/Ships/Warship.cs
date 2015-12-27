namespace Battleships.Ships
{


    public class Warship : BattleShip
    {
        const string AttackMsg = "Victory is ours!";
        public Warship(string name, double lengthInMeters, double volume)
            : base(name, lengthInMeters, volume)
        {
        }

        public override string Attack(Ship targetShip)
        {
           this.DestroyShip(targetShip);
            return AttackMsg;
        }
    }
}
