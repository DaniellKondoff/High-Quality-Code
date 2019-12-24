namespace _02.SimpleFactory.Interfaces
{
    public interface IFanFactory
    {
        IFan CreateFan(FanType type);
    }
}
