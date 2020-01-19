namespace Skyrim
{
    using System.Collections.Generic;

    using Units;

    public class Program
    {
        static void Main()
        {
            // Dragon with 100 HP
            var dragon = new Dragon("Alduin", 300, 100);

            var warior1 = new Warrior("Cicero", 15, 50);
            var warior2 =  new Warrior("Ulfric Stormcloak", 80, 80);
            var warior3 =  new Warrior("Jarl Balgruuf", 40, 30);

            var warriors = new List<Warrior>();
            warriors.Add(warior1);
            warriors.Add(warior2);
            warriors.Add(warior3);

            dragon.UpdateWarriorWeapon += warior1.HandleEvent;
            dragon.UpdateWarriorWeapon += warior2.HandleEvent;

            // Nothing happens
            dragon.HealthPoints -= 20;
            // Nothing happens
            dragon.HealthPoints -= 10;
            // Dragon dies
            dragon.HealthPoints -= 90;

            foreach (var warrior in warriors)
            {
                System.Console.WriteLine(warrior);
            }
        }
    }
}
