using System;
using SAGame_v0._2.Interfaces;

namespace SAGame_v0._2.Models.EnemyBattleShips
{
    public abstract class Enemy : Characters
    {

        private int damage;
        private int damageStatus;
        private Position position;

        protected Enemy(int damage, int damageStatus, Position position)
        {

            this.Damage = damage;
            this.DamageStatus = damageStatus;
            this.Position = position;
        }

        public virtual int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Damage should be a positive number");
                }
                this.damage = value;
            }
        }

        public int DamageStatus
        {
            get { return this.damageStatus; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("DamageStatus should be a positive number");
                }
                this.damageStatus = value;
            }
        }


        public Position Position
        {
            get { return this.position; }

            set
            {
                //if ()
                this.position = value;
            }
        }

        public virtual void Attack(ICharacter enemy)
        {
            while (enemy.DamageStatus != 0)
            {
                enemy.DamageStatus = -this.Damage;
            }
        }

    }
}
