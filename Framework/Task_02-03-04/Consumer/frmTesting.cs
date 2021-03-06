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
using Framework.Collision;

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
            game.OnPlayerDie+=new EventHandler(removePlayerFromControls);
            //Boundary of the form
            Point boundary = new Point(this.Width, this.Height);
            //Adding game object//
            game.addGameObject(ObjectType.enemy,Consumer.Properties.Resources.attackLeft, 20, 20, new Keyboard(10, boundary));
            game.addGameObject(ObjectType.player,Consumer.Properties.Resources.enemyAttackLeft, 50, 100, new Horizontal(10, boundary, "left"));
            //Adding collision
            CollisionClass c = new CollisionClass(ObjectType.player, ObjectType.enemy, new PLayerCollision());
            game.addCollsionIntoList(c);
        }

        private void removePlayerFromControls(object sender, EventArgs e)
        {
            this.Controls.Remove((PictureBox)sender);
            this.Controls.Remove((PictureBox)null);
            
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
