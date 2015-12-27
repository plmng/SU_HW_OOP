namespace Battleships.Ships
{
    using System;

    public class AircraftCarrier : BattleShip
    {
       
        private int fighterCapacity;
        const string AttackMsg = "We bombed them from the sky!";

        public AircraftCarrier(string name, double lengthInMeters, double volume, int fighterCapacity)
            : base(name, lengthInMeters, volume)
        {
            this.FighterCapacity = fighterCapacity;
        }

        
        public int FighterCapacity
        {
            get
            {
                return this.fighterCapacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The fighter capacity of an aircraft carrier cannot be negative.");
                }

                this.fighterCapacity = value;
            }
        }


        public override string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return AttackMsg;
        }
    }
}
