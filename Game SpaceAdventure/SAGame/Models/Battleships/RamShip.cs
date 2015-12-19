using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame.Attributes;

namespace SAGame.Models.Battleships
{
    [Enemy]
    public class RamShip : Character
    {
        private const int DefaultGunShipDamageStatus = 200;
        private const int DefaultGunshipDamage = 150;

        public RamShip(Position position) : base(DefaultGunshipDamage, DefaultGunShipDamageStatus, position)
        {
  
        }
       
    }
}
