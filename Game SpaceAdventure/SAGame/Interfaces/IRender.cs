namespace SAGame.Interfaces
{
    public interface IRender
    {
        void WriteLine(string message, params object[] parameters);

        void Clear();
    }
}
