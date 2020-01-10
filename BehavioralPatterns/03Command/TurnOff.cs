using System;

namespace _03Command
{
    public class TurnOff : ICommand
    {
        private Bulb mBulb;
        public TurnOff(Bulb bulb)
        {
            mBulb = bulb ?? throw new ArgumentNullException("Bulb", "Bulb cannot be null");
        }

        public void Execute()
        {
            mBulb.TurnOff();
        }

        public void Undo()
        {
            mBulb.TurnOn();
        }

        public void Redo()
        {
            Execute();
        }
    }
}
