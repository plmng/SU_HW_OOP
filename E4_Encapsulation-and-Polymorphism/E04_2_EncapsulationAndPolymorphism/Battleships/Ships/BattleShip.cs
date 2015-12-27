namespace Battleships.Ships
{
    using Interfaces;

    public abstract class BattleShip : Ship, IAttackable
    {
        
        protected BattleShip(string name, double lengthInMeters, double volume) 
            : base(name, lengthInMeters, volume)
        {
          //  this.IsBattleship = true;
        }

        public abstract string Attack(Ship targetShip);
       

        protected void DestroyShip(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }


    }
}
