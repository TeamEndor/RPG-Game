using System;
using SAGame.Interfaces;

namespace SAGame.Models
{
    public abstract class Character : ICharacter
    {

        private int damage;
        private int damageStatus;
        private Position position;

        protected Character(int damage, int damageStatus, Position position)
        {
            this.Damage = damage;
            this.DamageStatus = damageStatus;
            this.Position = position;
        }

        public int Damage
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int DamageStatus
        {
            get { throw new NotImplementedException(); }

            set { throw new NotImplementedException(); }
        }


        public Position Position
        {
            get { throw new NotImplementedException(); }

            set { throw new NotImplementedException(); }
        }

        public void Attack(ICharacter enemy)
        {
            int damageInflicted = this.Damage - enemy.DamageStatus;

            if (damageInflicted > 0)
            {
                enemy.DamageStatus-= this.Damage;
            }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
