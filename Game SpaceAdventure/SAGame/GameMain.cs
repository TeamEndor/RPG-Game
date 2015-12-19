
using SAGame.Enums;
using SAGame.Engine;
namespace SAGame
{
    using Models.Battleships;
    using Engine;
    using Interfaces;
    using Items;
    using Items.Weapons;
    using UI;

    public class GameMain
    {

        public static void Main()
        {

            IRenderer renderer = new Renderer();
            IInputReader inputReader = new InputReader();
            IPlayer player = new Starfighter();
            SeedInitialPlayerInventory(player);

           IEngine engine = new Engine.Engine(renderer,inputReader,player);

            engine.Run();
        }

        private static void SeedInitialPlayerInventory(IPlayer player)
        {
            Position defaultPosition = new Position(0, 0);


            ICollectible weapon = new RegularDC17(defaultPosition);
            weapon.State = ItemState.Collected;
            player.AddItemToInventory(weapon);
        }


    }
}
