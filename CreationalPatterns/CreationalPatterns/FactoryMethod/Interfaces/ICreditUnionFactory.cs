namespace FactoryMethod.Interfaces
{
    public interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }
}
