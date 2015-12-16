using System;

using SAGame.Interfaces;
using SAGame.Enums;

namespace SAGame.Items
{
    public abstract class Item : ICollectible
    {


        public ItemState State
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
