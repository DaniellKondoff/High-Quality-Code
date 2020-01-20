using AirCombat.Entities.Parts.Contracts;
using System;

namespace AirCombat.Entities.Parts
{
    public class EndurancePart : Part, IHitPointsModifyingPart
    {
        private int hitPointsModifier;
        public EndurancePart(string model, double weight, decimal price, int hitPointsModifier) : base(model, weight, price, hitPointsModifier)
        {
            this.HitPointsModifier = hitPointsModifier;
        }

        public int HitPointsModifier
        {
            get
            {
                return this.hitPointsModifier;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("HitPointsModifier cannot be less or equal to zero!");
                }

                this.hitPointsModifier = value;
            }
        }

        public override string ToString()
        {
           return $"Endurance Part - {this.Model} {this.HitPointsModifier} HitPoints";
        }
    }
}
