using AirCombat.Entities.AirCrafts.Contracts;
using AirCombat.Utils;
using System.Collections.Generic;

namespace AirCombat.Commands
{
    public class AddAirCraftCommand : Command
    {
        
        public AddAirCraftCommand(IList<string> arguments) : base(arguments)
        {
            
        }

        public override string Execute()
        {
            string aircraftType = arguments[0];
            string model = arguments[1];
            double weight = double.Parse(arguments[2]);
            decimal price = decimal.Parse(arguments[3]);
            int attack = int.Parse(arguments[4]);
            int defense = int.Parse(arguments[5]);
            int hitPoints = int.Parse(arguments[6]);

            IAirCraft aircraft = aircraftFactory.CreateAirCraft(aircraftType, model, weight, price, attack, defense, hitPoints);

            if (aircraft != null && !aircrafts.ContainsKey(aircraft.Model))
                aircrafts.Add(aircraft.Model, aircraft);

            return string.Format(GlobalConstants.AircraftSuccessMessage, aircraftType, aircraft.Model);
        }
    }
}
