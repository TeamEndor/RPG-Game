using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Interfaces;

namespace SAGame_v0._2.Models
{
    public abstract class Characters : ICharacter
    {
        private int damage;
        private int shieldStatus;
        private Position position;

        protected Characters(string name, int damage, int shieldStatus, Position position)
        {
            this.Name = name;
            this.Damage = damage;
            this.ShieldStatus = shieldStatus;
            this.Position = position;
        }

        public string Name { get; }

        public virtual int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Damage should be a positive number");
                }
                this.damage = value;
            }
        }

        public int ShieldStatus
        {
            get { return this.shieldStatus; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "DamageStatus should be a positive number");
                }
                this.shieldStatus = value;
            }
        }

        public Position Position
        {
            get
            {
                return this.position;
            }

            set
            {
                if (value.X < 0 || value.Y < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Position can't be a negative number!");
                }
                this.position = value;
            }
        }

        public virtual void Attack(ICharacter target)
        {
            while (target.ShieldStatus > 0 || this.ShieldStatus <= 0)
            {
                target.ShieldStatus -= this.Damage;
                this.ShieldStatus -= target.Damage;
            }
        }

        public override string ToString()
        {
            StringBuilder status = new StringBuilder();
            status.AppendFormat("{0} shield status: {1}", this.Name, this.ShieldStatus);
            return status.ToString();
        }
    }
}
