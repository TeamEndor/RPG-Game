using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame.Items.Weapons
{
    public class RegularDC17: Weapon
    {
        private const int DefaultRegularDC17Damage = 100;

        public RegularDC17(Position position, int damage) : base(position, DefaultRegularDC17Damage)
        {
        }
    }
}
