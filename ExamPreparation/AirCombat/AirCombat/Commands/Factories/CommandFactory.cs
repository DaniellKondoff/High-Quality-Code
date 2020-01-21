using AirCombat.Commands.Contracts;
using AirCombat.Commands.Factories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AirCombat.Commands.Factories
{
    public class CommandFactory : ICommandFactory
    {
        private const string CommandNameSuffix = "Command";

        public ICommand CreateCommand(string commandType, IList<string> arguments)
        {
            Type type = Assembly.GetCallingAssembly()
                                .GetTypes()
                                .FirstOrDefault(t => t.Name.Contains(commandType + CommandNameSuffix));

            var constructorInfo = type.GetConstructors();

            ICommand command = (ICommand)Activator.CreateInstance(type, arguments);

            return command;
        }
    }
}
