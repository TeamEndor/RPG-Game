using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame_v0._2.Interfaces
{
    public interface IPlayer : ICollect
    {
        int Munitions { get; }
        int Energy { get; }
        void CollectMunitions();
    }
}
