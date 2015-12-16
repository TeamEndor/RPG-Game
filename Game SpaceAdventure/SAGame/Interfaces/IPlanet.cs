namespace SAGame.Interfaces
{
    public interface IPlanet: IGameObject, IResource
    {
        string Name { get; set; }
    }
}
