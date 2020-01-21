using AirCombat.Core;
using AirCombat.Core.Contracts;
using AirCombat.Utils;
using System.Collections.Generic;
using System.Linq;

namespace AirCombat.Commands
{
    public class BattleCommand : Command
    {
        
        private readonly IBattleOperator battleOperator;
        public BattleCommand(IList<string> arguments) : base(arguments)
        {
            
            this.battleOperator = new BattleOperator();
        }

        public override string Execute()
        {
            string attackerAircraftModel = arguments[0];
            string targetAircraftModel = arguments[1];

            string winnerAircraftModel = this.battleOperator.Battle(aircrafts[attackerAircraftModel], aircrafts[targetAircraftModel]);

            if (winnerAircraftModel.Equals(attackerAircraftModel))
            {
                aircrafts[targetAircraftModel]
                    .Parts
                    .ToList()
                    .ForEach(x => parts.Remove(x.Model));

                aircrafts.Remove(targetAircraftModel);
                defeatedAircrafts.Add(targetAircraftModel);
            }
            else
            {
                aircrafts[attackerAircraftModel]
                    .Parts
                    .ToList()
                    .ForEach(x => parts.Remove(x.Model));

                aircrafts.Remove(attackerAircraftModel);

                defeatedAircrafts.Add(attackerAircraftModel);
            }

            return string.Format(
                GlobalConstants.BattleSuccessMessage,
                attackerAircraftModel,
                targetAircraftModel,
                winnerAircraftModel);
        }
    }
}
