using _05._Builder.FlientInterface;
using System;

namespace _05._Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Burger burger = new BurgerBuilder(5)
                                .AddPepperoni()
                                .Build();
        }
    }
}
