using AirCombat.Entities.Parts.Contracts;
using System;

namespace AirCombat.Entities.Parts
{
    public class ShellPart : Part, IDefenseModifyingPart
    {
        private int defenseModifier;
        public ShellPart(string model, double weight, decimal price, int defenseModifier) : base(model, weight, price, defenseModifier)
        {
            this.DefenseModifier = defenseModifier;
        }

        public int DefenseModifier
        {
            get
            {
                return this.defenseModifier;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("DefenseModifier cannot be less or equal to zero!");
                }

                this.defenseModifier = value;
            }
        }

        public override string ToString()
        {
            return $"Shell Part - {this.Model} {this.DefenseModifier} Defense";
        }
    }
}
