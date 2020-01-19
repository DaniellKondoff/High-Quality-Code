namespace Skyrim.Units
{
    using System.Collections.Generic;
    using System.Text;
    using Observer;
    using Skyrim.Items;

    public class Warrior : Unit, IDragonDeathObserver
    {
        public Warrior(string name, int attackPoints, int healthPoints) 
            : base(name, attackPoints, healthPoints)
        {
            this.Inventory = new List<Weapon>();
        }

        public IList<Weapon> Inventory { get; private set; }

        public void Update(Weapon weapon)
        {
            this.Inventory.Add(weapon);
        }

        public void HandleEvent(object sender, Weapon weapon)
        {
            Update(weapon);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Name);

            foreach (var weapon in Inventory)
            {
                sb.Append(weapon.ToString());
            }

            return sb.ToString();
        }
    }
}
