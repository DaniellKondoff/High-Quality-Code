using RPG.Weapons;

namespace RPG.Characters
{
    public abstract class Character
    {
        protected Character(Weapon weapon)
        {
            this.Weapon = weapon;
        }
        public Weapon Weapon { get; protected set; }
    }
}
