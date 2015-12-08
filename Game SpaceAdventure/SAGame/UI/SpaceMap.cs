using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAGame.Models.Characters;
using SAGame.Models.Planets;

namespace SAGame.UI
{
    class SpaceMap : Map
    {
        private static readonly Bitmap SpaceMapImage = new Bitmap("Space.jpg");
        private PictureBox pictureBox;
        private Player alien;
        private EarthPlanet earth;

        public SpaceMap(Form gameForm) 
            : base(gameForm, SpaceMapImage)
        {
            this.GameForm.Width = 2000;
            this.GameForm.Height = 2000;
            this.GameForm.BackgroundImage = SpaceMapImage;
            
            pictureBox = new PictureBox();
            pictureBox.Width = gameForm.Width;
            pictureBox.Height = gameForm.Height;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Parent = gameForm;

            this.alien = new Player(new Point(0, 0));
            this.earth = new EarthPlanet(new Point(800, 800));
            
        }



        public override void DrawMap(Graphics device)
        {


            for (int x = 0; x < 27; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Pen pen = new Pen(Color.Blue);  //////////////////////////////Color.Transparent
                    device.DrawRectangle(pen, x * 50, y * 50, 50, 50);
                }

            }
        }


        //public void Draw()
        //{
        //    Image image = new Bitmap(SpaceMapImage);
        //    Graphics device = Graphics.FromImage(image);

        //    DrawMap(device);
        //    alien.DrawPlayer(alien.Location);

        //    earth.DrawPlanet(earth.Location);

        //    pictureBox.Image = image;
        //}


        public void HandeleKeyPress(KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Left)
            //{
            //    alien.Move(-1, 0);
            //}

            //if (e.KeyCode == Keys.Right)
            //{
            //    alien.Move(1, 0);
            //}

            //if (e.KeyCode == Keys.Up)
            //{
            //    alien.Move(0, -1);
            //}

            //if (e.KeyCode == Keys.Down)
            //{
            //    alien.Move(0, 1);
            //}

            //Draw();
        }





    }
}
