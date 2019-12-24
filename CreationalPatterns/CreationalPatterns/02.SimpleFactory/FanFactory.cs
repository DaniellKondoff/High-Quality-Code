using _02.SimpleFactory.Interfaces;
using System;

namespace _02.SimpleFactory
{
    public class FanFactory : IFanFactory
    {
        public IFan CreateFan(FanType type)
        {
            switch (type)
            {
                case FanType.TableFan:
                    return new TableFan();
                case FanType.CeilingFan:
                    return new CeilingFan();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
