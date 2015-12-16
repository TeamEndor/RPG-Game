namespace SAGame.Interfaces
{
    public interface IPlayer : ICharacter, IMovable, ICollect
    {
        int Munitions { get; set; }

        int Fuel { get; set; }

        int QuantityResources { get; set; }
    }
}
