using System;

namespace _04Template
{
    public class IosBuilder : Builder
    {
        protected override void Assemble()
        {
            Console.WriteLine("Assembling the ios build");
        }

        protected override void Deploy()
        {
            Console.WriteLine("Deploying ios build to server");
        }

        protected override void Lint()
        {
            Console.WriteLine("Linting the ios code");
        }

        protected override void Test()
        {
            Console.WriteLine("Running ios tests");
        }
    }
}
