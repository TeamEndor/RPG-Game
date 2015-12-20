using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Interfaces;

namespace SAGame_v0._2.Items.Weapons
{
    public abstract class Weapon : Item, IDamageInflict
    {
        protected Weapon(Position position, int damage) : base(position)
        {
            this.Damage = damage;
        }

        public int Damage { get; set; }
    }
}
