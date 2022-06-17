using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Core;
using Framework.Movement;

namespace Consumer
{
    public partial class frmTesting : Form
    {
        Game game;
        public frmTesting()
        {
            InitializeComponent();
        }
        private void frmTesting_Load_1(object sender, EventArgs e)
        {
            game = new Game(5);
            //Event handlers
            game.OnGameObjectAdded += new EventHandler(addIntoFormControls);
            //Boundary of the form
            Point boundary = new Point(this.Width, this.Height);
            //Adding game object
            game.addGameObject(Consumer.Properties.Resources.pic, 20, 20,new Horizontal(3,boundary,"left"));
            game.addGameObject(Consumer.Properties.Resources.fir, 20, 20, new Keyboard(3, boundary));
        }
        private void addIntoFormControls(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
        }

        private void frmTesting_KeyDown(object sender, KeyEventArgs e)
        {
            game.keyPressed(e.KeyCode);  
        }
    }
}
