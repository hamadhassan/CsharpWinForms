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
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(5);
            game.OnGameObjectAdded += Game_onGameObjectAdded;
            game.addGameObject(ConsumerFramework.Properties.Resources.actor, 50, 50);
        }
        private void Game_onGameObjectAdded(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            this.Controls.Add(pb);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.update();
        }
    }
}
