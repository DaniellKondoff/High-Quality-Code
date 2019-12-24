using System;

namespace _01.SIngleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger firstLogger = Logger.Instance;
            Logger secondLogger = Logger.Instance;

            Console.WriteLine(firstLogger.GetHashCode() == secondLogger.GetHashCode());
        }
    }
}
