using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGame.Models.Planets
{
    public class EarthPlanet : Planet
    {
        private const string EarthPlanetName = "Earth";
        private static readonly Bitmap EarthImage = new Bitmap("Earth1.png");

        public EarthPlanet(Point location) 
            : base(location, EarthImage, EarthPlanetName)
        {
          
        }

        public override void DrawPlanet(Point coordinates)
        {
            Graphics device = Graphics.FromImage(EarthImage);
            device.DrawImage(EarthImage, coordinates);
        }
    }
    
}
