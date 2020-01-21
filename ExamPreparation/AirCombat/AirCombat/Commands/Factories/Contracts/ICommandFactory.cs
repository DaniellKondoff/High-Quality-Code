using AirCombat.Commands.Contracts;
using System.Collections.Generic;

namespace AirCombat.Commands.Factories.Contracts
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandType, IList<string> arguments);
    }
}
