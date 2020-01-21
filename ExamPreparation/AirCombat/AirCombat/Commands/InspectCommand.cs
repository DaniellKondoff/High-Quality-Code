using System.Collections.Generic;

namespace AirCombat.Commands
{
    public class InspectCommand : Command
    {
        public InspectCommand(IList<string> arguments) : base(arguments)
        {
        }

        public override string Execute()
        {
            string model = arguments[0];

            string result = aircrafts.ContainsKey(model) ?
                aircrafts[model].ToString() :
                parts[model].ToString();

            return result;
        }
    }
}
