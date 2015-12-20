using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Core.Engine;
using SAGame_v0._2.Interfaces;
using SAGame_v0._2.UI;

namespace SAGame_v0._2
{
    class GameMain
    {
        static void Main()
        {
            IInputReader reader = new InputReader();
            IRenderer renderer = new Renderer();

            //IPlayer player = new Starfighter();
            //SeedInitialPlayerInventory(player);

            IEngine engine = new GameEngine(reader, renderer);
            engine.Run();
        }

        //private static void SeedInitialPlayerInventory(IPlayer player)
        //{
        //    Position defaultPosition = new Position(0, 0);


        //    ICollectible weapon = new RegularDC17(defaultPosition);
        //    weapon.State = ItemState.Collected;
        //    player.AddItemToInventory(weapon);
        //}
    }
}

