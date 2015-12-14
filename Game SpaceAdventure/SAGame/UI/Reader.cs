using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame.Interfaces;

namespace SAGame.UI
{
    public class Reader : IReader
    {
        public string Reade()
        {
            return Console.ReadLine(); 
        }
    }
}
