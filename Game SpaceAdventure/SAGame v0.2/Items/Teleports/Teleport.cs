using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Interfaces;
using SAGame_v0._2.Models.PlayerBattleShips;

namespace SAGame_v0._2.Items.Teleports
{
    public abstract class Teleport : Item
    {
        private readonly IPlayer player;
        private static readonly Random Rand = new Random();

        public Teleport(Position position) : base(position)
        {
        }

        public void TeleportPlayer(Player player)
        {
            //int randPosX = Rand.Next(1, Constants.MapWidth);
            //int randPosY = Rand.Next(1, Constants.MapHeight);

            //this.player.Position = new Position(this.player.Position.X - randPosX, this.player.Position.Y + randPosY);

        }
    }
}
