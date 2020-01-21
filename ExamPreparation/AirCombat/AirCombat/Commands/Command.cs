using AirCombat.Commands.Contracts;
using AirCombat.Entities.AirCrafts.Contracts;
using AirCombat.Entities.AirCrafts.Factories;
using AirCombat.Entities.AirCrafts.Factories.Contracts;
using AirCombat.Entities.Parts.Contracts;
using AirCombat.Entities.Parts.Factories;
using AirCombat.Entities.Parts.Factories.Contracts;
using System.Collections.Generic;

namespace AirCombat.Commands
{
    public abstract class Command : ICommand
    {
        protected readonly IList<string> arguments;
        protected readonly IAirCraftFactory aircraftFactory;
        protected readonly IPartFactory partFactory;
        protected static readonly IDictionary<string, IAirCraft> aircrafts = new Dictionary<string, IAirCraft>();
        protected static readonly IDictionary<string, IPart> parts = new Dictionary<string, IPart>();
        protected static readonly IList<string> defeatedAircrafts = new List<string>();
        protected Command(IList<string> arguments)
        {
            this.arguments = arguments;
            this.partFactory = new PartFactory();
            this.aircraftFactory = new AirCraftFactory();
        }

        public abstract string Execute();
    }
}
