namespace SAGame.Interfaces
{
    public interface IPlayer : IAttack, IDestroyable, IGameObject, IDamageInflict, ICollect
    {
        int Munitions { get; set; }

        int QuantityResources { get; set; }
    }
}
