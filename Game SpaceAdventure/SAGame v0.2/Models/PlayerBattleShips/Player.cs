using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGame_v0._2.Interfaces;
using SAGame_v0._2.Items;
using SAGame_v0._2.Items.Weapons;

namespace SAGame_v0._2.Models.PlayerBattleShips
{
    public abstract class Player : Characters, IPlayer
    {
        private const int DefaultPlayerXPosition = 0;
        private const int DefaultPlayerYPosition = 0;

        private int munitions;
        private int energy;
        private readonly IList<Item> inventory = new List<Item>();
        private readonly int intialNumberOfMunitions;

        protected Player(string name, int damage, int shieldStatus, int munitions, int energy) 
            : base(name, 
                  damage, 
                  shieldStatus, 
                  new Position(DefaultPlayerXPosition, DefaultPlayerYPosition))
        {
            this.Munitions = munitions;
            this.Energy = energy;
            this.intialNumberOfMunitions = this.Munitions;   ///////////////////////////////////////
        }

        public override int Damage => UpdateDamage();

        public int Munitions
        {
            get { return this.munitions; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Munitions should be a positive number");
                }
                this.munitions = value;
            }
        }

        public int Energy
        {
            get { return this.energy; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), 
                        "Energy should be a positive number in the range [0..100]");
                }
                this.energy = value;
            }
        }
        public IEnumerable<Item> Inventory => this.inventory;

        private int UpdateDamage()
        {
            int updatedDamage = this.Damage;    //////////////////////////////////////////this.damage

            updatedDamage += this.inventory
                .Where(w => w is Weapon)
                .Cast<Weapon>()
                .Select(w => w.Damage)
                .Max();
            return updatedDamage;
        }

        //public override void Attack(ICharacter target)
        //{
            //this.intialNumberOfMunitions = this.Munitions;

            //    while (enemy.DamageStatus != 0)
            //    {
            //        enemy.DamageStatus = -this.Damage;

            //        if (this.Energy < 100)
            //        {
            //            this.Energy++;
            //        }

            //        if (this.Energy == 100)
            //        {
            //            enemy.DamageStatus = -2 * this.Damage; ;
            //        }

            //        this.Munitions = -10;
            //        if (this.Munitions == 0)
            //        {
            //            //Console.WriteLine("No more munitions.Please Reload !!! ");
            //            break;
            //        }
            //    }
        //}
        
        public void AddItemToInventory(Item item)
        {
            this.inventory.Add(item);
        }
        
        public void CollectMunitions()
        {
            if (this.Munitions <= intialNumberOfMunitions)
            {
                this.Munitions += 10;
            }

            //while (this.Munitions < intialNumberOfMunitions)
            //{
            //    this.Munitions += 10;

            //    if (this.Munitions == intialNumberOfMunitions)
            //    {
            //        break;
            //    }
            //}
        }

        public override string ToString()
        {
            StringBuilder playerStatus = new StringBuilder();
            playerStatus.Append(base.ToString());
            playerStatus.AppendFormat(" , munitions: {0}, energy: {1}", this.Munitions, this.Energy);
            
            return playerStatus.ToString();
        }
    }
}
