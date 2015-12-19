namespace SAGame.Interfaces
{
    public interface IEngine
    {
        bool IsRunning { get; }

        void Run();
    }
}
