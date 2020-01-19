using Skyrim.Items;
using System;
using System.Collections.Generic;

namespace Skyrim.Units
{
    public class Dragon : Unit
    {
        private IList<Warrior> warriors;
        public event EventHandler<Weapon> UpdateWarriorWeapon;
        public Dragon(string name, int attackPoints, int healthPoints) 
            : base(name, attackPoints, healthPoints)
        {
            this.warriors = new List<Warrior>();
        }

        public override int HealthPoints 
        { 
            get => base.HealthPoints;
            set
            {
                base.HealthPoints = value;
                if (HealthPoints < 0)
                    Notify();
            }
        }

        public void Attach(Warrior warrior)
        {
            this.warriors.Add(warrior);
        }

        public void Detach(Warrior warrior)
        {
            this.warriors.Remove(warrior);
        }


        private void Notify()
        {
            UpdateWarriorWeapon?.Invoke(this, new Weapon(100, 200));
        }
    }
}
