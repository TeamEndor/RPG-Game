using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Enums;
using SAGame_v0._2.Interfaces;

namespace SAGame_v0._2.Items
{
    public abstract class Item : ICollectible
    {
        private Position position;
        protected Item(Position position)
        {
            this.Position = position;
            this.State = ItemState.Available;
        }

        public Position Position { get; set; }


        public ItemState State { get; set; }
    }
}
