using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeveloperFramework;

namespace ConsumerFramework
{
    public partial class frmTesting : Form
    {
        Game game;
        public frmTesting()
        {
            InitializeComponent();
           
        }
        private void frmTesting_Load(object sender, EventArgs e)
        {
            game = new Game(5);
            game.OnGameObjectAdded += new EventHandler(addIntoFormControls);
            game.addGameObject(ConsumerFramework.Properties.Resources.actor, 20, 20);
        }
        private void addIntoFormControls(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.update();
        }

       
    }
}
