using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame.Attributes;

namespace SAGame.Models.Battleships
{
    [Enemy]
    public class WarShip: Character
    {
        private const int DefaultGunShipDamageStatus = 270;
        private const int DefaultGunshipDamage = 100;

        public WarShip(Position position) : base(DefaultGunshipDamage, DefaultGunShipDamageStatus, position)
        {
        }
     
    }
}
