namespace SAGame.Interfaces
{
    public interface IStarshipUnit : IAttack, IDestroyable, IDamageInflict
    {
        string Name { get; set; }
    }
}
