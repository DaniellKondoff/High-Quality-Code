using RPG.Weapons;

namespace RPG.Characters
{
    public class Warrior : Character
    {
        public Warrior(Weapon weapon) : base(weapon)
        {         
        }

        public override string ToString()
        {
            return string.Format("{0} wields weapon {1}", nameof(Warrior), this.Weapon.GetType().Name);
        }
    }
}
