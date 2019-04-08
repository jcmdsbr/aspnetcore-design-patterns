namespace Command
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}