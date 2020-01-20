using AirCombat.Entities.Parts.Contracts;
using System;

namespace AirCombat.Entities.Parts
{
    public class ArsenalPart : Part, IAttackModifyingPart
    {
        private int attackModifier;
        public ArsenalPart(string model, double weight, decimal price, int attackModifier) : base(model, weight, price, attackModifier)
        {
            this.AttackModifier = attackModifier;
        }

        public int AttackModifier
        {
            get
            {
                return this.attackModifier;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("AttackModifier cannot be less or equal to zero!");
                }

                this.attackModifier = value;
            }
        }

        public override string ToString()
        {
            return $"Arsenal Part - {this.Model} {this.AttackModifier} Attack";
        }
    }
}
