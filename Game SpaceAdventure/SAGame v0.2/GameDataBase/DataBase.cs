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
        private readonly IList<Player> player = new List<Player>();
        private readonly ICollection<IPlayer> playerShipsChoice = new List<IPlayer>()
        {
            new StarFighter(),
            new MillenniumFalcon()
        };
        private readonly IList<ICharacter> enemy = new List<ICharacter>();

        public IList<Player> Player => this.player;
        public IEnumerable<IPlayer> PlayerShipsChoice => this.playerShipsChoice;
        public IList<ICharacter> Enemy => this.enemy;

        //public void AddPlayer(IPlayer character)
        //{
        //    this.player.Add(character);
        //}

        //public void AddEnemy(ICharacter character)
        //{
        //    this.enemy.Add(character);
        //}

        public void AddToPlayerShipsChoice(IPlayer character)
        {
            this.playerShipsChoice.Add(character);
        }
        
    }
}
