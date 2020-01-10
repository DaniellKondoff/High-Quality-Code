namespace _03Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
