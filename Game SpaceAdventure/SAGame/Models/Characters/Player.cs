using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame.Models.Characters
{
    public class Player : Character
    {
        private static readonly Bitmap PlayerImage = new Bitmap("SpaceStation2.png");
        private const string PlayerName = "Alien";

        public Player(Point location) 
            : base(location, PlayerImage, PlayerName)
        {
           
        }


        public override void DrawPlayer(Point coordinates)
        {
           Graphics device = Graphics.FromImage(PlayerImage);
            device.DrawImage(PlayerImage, coordinates);

        }
    }
    
}
