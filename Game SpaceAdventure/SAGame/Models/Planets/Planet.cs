using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SAGame.Models.Planets
{
    public abstract class Planet
    {
        private Point location;
        private Bitmap image;
        private string name;

        protected Planet(Point location, Bitmap image, string name)
        {
            this.Location = location;
            this.Image = image;
            this.Name = name;
        }

        public Point Location { get; set; }
        public Bitmap Image { get; protected set; }
        public string Name { get; protected set; }

        public abstract void DrawPlanet(Point coordinates);


    }
}
