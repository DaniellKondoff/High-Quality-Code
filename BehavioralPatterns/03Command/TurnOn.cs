using System;

namespace _03Command
{
    // Command
    public class TurnOn : ICommand
    {
        private Bulb mBulb;

        public TurnOn(Bulb bulb)
        {
            mBulb = bulb ?? throw new ArgumentNullException("Bulb", "Bulb cannot be null");
        }

        public void Execute()
        {
            mBulb.TurnOn();
        }

        public void Undo()
        {
            mBulb.TurnOff();
        }

        public void Redo()
        {
            Execute();
        }
    }
}
