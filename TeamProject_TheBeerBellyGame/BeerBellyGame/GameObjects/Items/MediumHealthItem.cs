﻿namespace BeerBellyGame.GameObjects.Items
{
    using Characters;
    using Interfaces;

    public class MediumHealthItem : CollectableItem, IHealable
    {
        public MediumHealthItem()
        {
            this.AvatarUri = AppSettings.HealthItemAvatar;
            this.RegenAmount = 20;
        }
        
        public int RegenAmount { get; private set; }

        public override void Consume(Character ch)
        {
            ch.Health += this.RegenAmount; ;
        }
    }
}