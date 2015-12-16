namespace SAGame.Interfaces
{
    public interface ICharacter:IAttack, IDestroyable, IGameObject, IDamageInflict
    {
        int Energy { get; set; }
        
    }
}
