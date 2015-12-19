using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame.Models.Battleships
{
    public class GunShip: Character
    {
        
        private const int DefaultGunShipDamageStatus = 150;
        private const int DefaultGunshipDamage = 60;
        

        public GunShip(Position position) : base(DefaultGunshipDamage, DefaultGunShipDamageStatus, position)
        {
        }
        public override string ToString()
        {
            string output = string.Format("Name: {1}{0}Damage status{2}{0}Damage{3}{0}", Environment.NewLine,
                this.GetType().Name, this.DamageStatus, this.Damage);

            return output;

        }
    }
}
