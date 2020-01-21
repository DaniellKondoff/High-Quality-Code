using AirCombat.Entities.Parts.Contracts;
using AirCombat.Utils;
using System.Collections.Generic;

namespace AirCombat.Commands
{
    public class AddPartCommand : Command
    {
        
        public AddPartCommand(IList<string> arguments) : base(arguments)
        {
            
        }

        public override string Execute()
        {
            string aircraftModel = arguments[0];
            string partType = arguments[1];
            string model = arguments[2];
            double weight = double.Parse(arguments[3]);
            decimal price = decimal.Parse(arguments[4]);
            int additionalParameter = int.Parse(arguments[5]);

            IPart part = partFactory.CreatePart(partType, model, weight, price, additionalParameter);

            if (!parts.ContainsKey(model))
                parts.Add(model, part);

            switch (partType)
            {
                case "Arsenal":
                    aircrafts[aircraftModel].AddArsenalPart(part);
                    break;
                case "Shell":
                    aircrafts[aircraftModel].AddShellPart(part);
                    break;
                case "Endurance":
                    aircrafts[aircraftModel].AddEndurancePart(part);
                    break;
            }

            return string.Format(GlobalConstants.PartSuccessMessage, partType, part.Model, aircraftModel);
        }
    }
}
