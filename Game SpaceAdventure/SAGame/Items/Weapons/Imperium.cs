using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame.Attributes;


namespace SAGame.Items.Weapons
{
    [Item]
    public class Imperium : Weapon
    {
        private const int DefaultImperiumDamage = 150;

        public Imperium(Position position) : base(position, DefaultImperiumDamage)
        {
        }
    }
}
