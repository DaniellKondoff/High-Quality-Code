using RPG.Weapons;

namespace RPG.Characters
{
    public class Mage: Character
    {
        public Mage(Weapon weapon) : base(weapon)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} wields weapon {1}", nameof(Mage), this.Weapon.GetType().Name);
        }
    }
}
