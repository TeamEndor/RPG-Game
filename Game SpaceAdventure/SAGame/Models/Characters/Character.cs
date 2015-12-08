using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAGame.UI;

namespace SAGame.Models
{
    public abstract class Character
    {
        private Point location;
        private Bitmap image;
        private string name;

        protected Character(Point location, Bitmap image, string name)
        {
            this.Location = location;
            this.Image = image;
            this.Name = name;
        }

        public Point Location { get; set; }
        public Bitmap Image { get; protected set; }
        public string Name { get; protected set; }

        public abstract void DrawPlayer(Point coordinates);
        
        public void Move(int x, int y)
        {
            this.location.X += x * 50;
            this.location.Y += y * 50;
        }
    }
}
