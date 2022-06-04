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
    public partial class CUTextBox : UserControl
    {
        private int txtlenght = 3;
        public CUTextBox()
        {
            InitializeComponent();
        }

        public int Txtlenght { get => txtlenght; set => txtlenght = value; }

        private void txtbxMessage_TextChanged(object sender, EventArgs e)
        {
            if (txtbxMessage.Text.Length >= txtlenght)
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
