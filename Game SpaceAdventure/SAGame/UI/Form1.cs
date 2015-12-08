using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAGame.UI;

namespace SAGame
{
    public partial class Form1 : Form
    {
        private SpaceMap game;
        public Form1()
        {
            InitializeComponent();
            this.game = new SpaceMap(this);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           this.game.HandeleKeyPress(e);
        }
        
    }
    
}
