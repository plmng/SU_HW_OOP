﻿namespace BeerBellyGame.GameObjects.Characters
{
    using System.Collections.Generic;
    
    using Enums;
    using Interfaces;
    using Items;
    
    public abstract class Character: GameObject, ICharacter
    {
        public const double DeffHealth = 100;

        protected Character(int lifes, IRace race)
        {
            this.IsAlive = true;
            this.Life = lifes;
            this.Health = DeffHealth;
            this.Race = race;
            this.AggressionRange = race.DefaultAggressionRange;
            this.Aggression = race.DefaultAggression;
            this.Description = race.Description;
            this.AvatarUri = race.DefaultAvatar;
        }

        public IRace Race { get; set; }
        public bool IsAlive { get; set; }
        public int Life { get; set; }
        public virtual double Health { get; set; }
        public int BeerBelly { get; set; }
        public int AggressionRange { get; set; }
        public double Aggression { get; set; }
        public string Description { get; set; }

        public double Money { get; set; }

        public ICollection<Direction> PossibleMovements(ICollection<MazeItem> objs)
        {
            var directions = new List<Direction>(){
                Direction.Down,
                Direction.Left,
                Direction.Right,
                Direction.Up
            };

            foreach (var o in objs)
            {
                directions.Remove(this.IntersectWith(o));
            }

            return directions;
        }

        public void EquipWeapon(WeaponItem i)
        {
            if (i.EquipedState)
            {
                this.Aggression -= i.AggressionValue;
                i.EquipedState = false;
            }
            else
            {
                this.Aggression += i.AggressionValue;
                i.EquipedState = true;
            }
        }

        public void EquipSpyTool(SpyToolItem st)
        {
            if (st.EquipedState)
            {
                this.AggressionRange -= st.AgressionRange;
                st.EquipedState = false;
            }
            else
            {
                this.AggressionRange += st.AgressionRange;
                st.EquipedState = true;
            }
        }
    }
}
