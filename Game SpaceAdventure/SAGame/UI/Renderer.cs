using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame.Interfaces;

namespace SAGame.UI
{
    public class Renderer : IRender
    {
        public void WriteLine(string message, params object[] parameters)
        {
            Console.WriteLine(message, parameters);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
