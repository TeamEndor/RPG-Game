using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAGame.Models;

namespace SAGame.UI
{
    abstract class Map
    {
        private Form gameForm;
        private Bitmap mapImage;

        protected Map(Form gameForm, Bitmap mapImage)
        {
            this.GameForm = gameForm;
            this.MapImage = mapImage;

        }

        public Form GameForm { get; protected set; }
        public Bitmap MapImage { get; protected set; }

        public abstract void DrawMap(Graphics device);

    }
}

