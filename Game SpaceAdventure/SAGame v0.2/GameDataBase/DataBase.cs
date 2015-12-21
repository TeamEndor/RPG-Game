using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Interfaces;
using SAGame_v0._2.Models.EnemyBattleShips;
using SAGame_v0._2.Models.PlayerBattleShips;

namespace SAGame_v0._2.GameDataBase
{
    public class DataBase : IDataBase
    {
        private readonly ICollection<IPlayer> player = new List<IPlayer>();
        private readonly ICollection<IPlayer> playerShipsChoice = new List<IPlayer>()
        {
            new StarFighter(),
            new MillenniumFalcon()
        };
        private readonly ICollection<ICharacter> enemy = new List<ICharacter>();
        
        public IEnumerable<IPlayer> Player => this.player;
        public IEnumerable<IPlayer> PlayerShipsChoice => this.playerShipsChoice;
        public IEnumerable<ICharacter> Enemy => this.enemy;

        public void AddPlayer(IPlayer character)
        {
            this.player.Add(character);
        }

        public void AddEnemy(ICharacter character)
        {
            this.enemy.Add(character);
        }

        public void AddToPlayerShipsChoice(IPlayer character)
        {
            this.playerShipsChoice.Add(character);
        }
    }
}
