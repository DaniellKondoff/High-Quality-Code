using System;

namespace _04Template
{
    public class AndroidBuilder : Builder
    {
        protected override void Assemble()
        {
            Console.WriteLine("Assembling the android build");
        }

        protected override void Deploy()
        {
            Console.WriteLine("Deploying android build to server");
        }

        protected override void Lint()
        {
            Console.WriteLine("Linting the android code");
        }

        protected override void Test()
        {
            Console.WriteLine("Running android tests");
        }
    }
}
