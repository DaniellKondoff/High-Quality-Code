using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirCombat.Commands
{
    public class TerminateCommand : Command
    {
        public TerminateCommand(IList<string> arguments) : base(arguments)
        {
        }

        public override string Execute()
        {
            StringBuilder finalResult = new StringBuilder();

            finalResult.Append("Remaining Aircrafts: ");

            if (aircrafts.Count > 0)
            {
                finalResult
                    .AppendLine(string.Join(", ",
                        aircrafts
                            .Values
                            .Select(v => v.Model)
                            .ToArray()));
            }
            else
            {
                finalResult.AppendLine("None");
            }

            finalResult.Append("Defeated Aircrafts: ");

            if (defeatedAircrafts.Count > 0)
            {
                finalResult
                    .AppendLine(string.Join(", ", defeatedAircrafts));
            }
            else
            {
                finalResult
                    .AppendLine("None");
            }

            finalResult
                .Append("Currently Used Parts: ")
                .Append(parts.Count);

            return finalResult.ToString();
        }
    }
}
