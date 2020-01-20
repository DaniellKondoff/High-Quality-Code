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

            while (isRunning)
            {
                List<string> input = reader.ReadLine().Split(' ').ToList();

                if (input.FirstOrDefault() == "Terminate")
                    isRunning = false;

                var result = commandInterpreter.ProcessInput(input);
                writer.WriteLine(result);

                
            }
        }
    }
}