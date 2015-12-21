using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Models.PlayerBattleShips;

namespace SAGame_v0._2.Interfaces
{
    public interface IDataBase
    {
        IEnumerable<IPlayer> Player { get; }
        IEnumerable<IPlayer> PlayerShipsChoice { get; }
        IEnumerable<ICharacter> Enemy { get; }

        void AddPlayer(IPlayer character);
        void AddEnemy(ICharacter character);
        void AddToPlayerShipsChoice(IPlayer character);
    }
}
