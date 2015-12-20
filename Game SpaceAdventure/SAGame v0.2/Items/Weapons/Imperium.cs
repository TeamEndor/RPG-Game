using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame_v0._2.Items.Weapons
{
    public class Imperium : Weapon
    {
        //Item
        private const int DefaultImperiumDamage = 150;

        public Imperium(Position position) : base(position, DefaultImperiumDamage)
        {
        }
    }
}
