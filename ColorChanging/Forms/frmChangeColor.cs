using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorChanging.BL;
using ColorChanging.DL;

namespace ColorChanging
{
    public partial class frmChangeColor : Form
    {
        public frmChangeColor()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           ChangeColor c=new ChangeColor();
           string color =c.getNextColor("Blue",ChangeColorDL.getChangeColorList());
           lblNext.Text=color;
           color = c.getPreviousColor("Blue", ChangeColorDL.getChangeColorList());
           lblPrevious.Text = color;
        }

        private void frmChangeColor_Load(object sender, EventArgs e)
        {
            ChangeColorDL.setIntoChangeColorList("Red");
            ChangeColorDL.setIntoChangeColorList("Green");
            ChangeColorDL.setIntoChangeColorList("Blue");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ChangeColor c = new ChangeColor();
            string color = c.getNextColor("Blue", ChangeColorDL.getChangeColorList());
            lblNext.Text = color;
            color = c.getPreviousColor("Blue", ChangeColorDL.getChangeColorList());
            lblPrevious.Text = color;
        }
    }
}
