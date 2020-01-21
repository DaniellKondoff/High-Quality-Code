namespace AirCombat.Core
{
    using Contracts;
    using IO.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine : IEngine
    {
        private bool isRunning;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(
            IReader reader, 
            IWriter writer, 
            ICommandInterpreter commandInterpreter)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandInterpreter = commandInterpreter;
            this.isRunning = false;
        }

        public void Run()
        {
            this.isRunning = true;

            List<string> commandOutput = new List<string>();
            while (isRunning)
            {
                List<string> input = reader.ReadLine().Split(' ').ToList();

                if (input[0].Trim() == "Terminate")
                    isRunning = false;

                commandOutput.Add(commandInterpreter.ProcessInput(input));
            }

            commandOutput.ForEach(s => writer.WriteLine(s));
        }
    }
}