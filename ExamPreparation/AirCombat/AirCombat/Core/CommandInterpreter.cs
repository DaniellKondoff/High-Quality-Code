namespace AirCombat.Core
{
    using System.Collections.Generic;
    using AirCombat.Commands.Contracts;
    using AirCombat.Commands.Factories;
    using AirCombat.Commands.Factories.Contracts;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly ICommandFactory commandFactory;

        public CommandInterpreter()
        {
            this.commandFactory = new CommandFactory();
        }

        public string ProcessInput(IList<string> inputParameters)
        {
            string commandType = inputParameters[0];
            inputParameters.RemoveAt(0);

            string result = string.Empty;

            ICommand command = this.commandFactory.CreateCommand(commandType, inputParameters);
            result = command.Execute();

            return result;
        }
    }
}