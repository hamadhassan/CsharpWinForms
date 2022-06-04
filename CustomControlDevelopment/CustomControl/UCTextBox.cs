using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class UCTextBox : UserControl
    {
        public UCTextBox()
        {
            InitializeComponent();
        }

        private void txtbxMessage_TextChanged(object sender, EventArgs e)
        {
            if (txtbxMessage.Text.Length >= 3)
            {
                lblMessage.Text = "Valid";
                lblMessage.BackColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Invalid";
                lblMessage.BackColor = Color.Red;

            }
        }
    }
}
