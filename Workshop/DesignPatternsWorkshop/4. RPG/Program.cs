namespace RPG
{
    using System;

    using Characters;
    using RPG.Weapons;

    public class Program
    {
        static void Main()
        {
            var axeWeapon = new Axe();
            var swordWeapon = new Sword();

            Warrior axeWarrior = new Warrior(axeWeapon);
            Console.WriteLine(axeWarrior);
            Warrior swordWarrior = new Warrior(swordWeapon);
            Console.WriteLine(swordWarrior);

            Mage axeMage = new Mage(axeWeapon);
            Console.WriteLine(axeMage);
            Mage swordMage = new Mage(swordWeapon);
            Console.WriteLine(swordMage);
        }
    }
}
