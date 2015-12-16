using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAGame.Engine;
using SAGame.Interfaces;


namespace SAGame
{
    public class GameMain
    {

        public static void Main()
        {
            IEngine engin = new Engine.Engine();
            engin.Run();
        }
    }
}
