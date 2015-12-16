using System;
using SAGame.Interfaces;

namespace SAGame.Models
{
    public abstract class Character : ICharacter
    {
        private int energy;
        private int damage;
        private int damageStatus;
        private Position position;

        protected Character(int energy, int damage, int damageStatus, Position position)
        {
            this.Energy = energy;
            this.Damage = damage;
            this.DamageStatus = damageStatus;
            this.Position = position;
        }

        public int Energy
        {
            get
            {
                
            }
            set
            {
                
            }
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
            
            while (enemy.DamageStatus != 0)
            {
                enemy.DamageStatus =- this.Damage;

                if (Energy < 100)
                {
                    this.Energy ++;
                }

                if (Energy == 100)
                {
                   enemy.DamageStatus =- 2 * this.Damage; ;
                }
            }
            
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
