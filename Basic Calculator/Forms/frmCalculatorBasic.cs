using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BsicCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

      
        private void btnPlus_Click(object sender, EventArgs e)
        {
            double first =double.Parse( txtbxFirst.Text);
            double second =double.Parse( txtbxSecond.Text);
            double result=first + second;
            txtbxResult.Text=Convert.ToString(result);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double first = double.Parse(txtbxFirst.Text);
            double second = double.Parse(txtbxSecond.Text);
            double result = first - second;
            txtbxResult.Text = Convert.ToString(result);
        }

        private void btnMultipliy_Click(object sender, EventArgs e)
        {
            double first = double.Parse(txtbxFirst.Text);
            double second = double.Parse(txtbxSecond.Text);
            double result = first * second;
            txtbxResult.Text = Convert.ToString(result);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double first = double.Parse(txtbxFirst.Text);
            double second = double.Parse(txtbxSecond.Text);
            double result = first / second;
            if(result < 0)
            {
                txtbxResult.Text = "Math Error";
            }
            else
            {
                txtbxResult.Text = Convert.ToString(result);
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                   txtbxFirst.Clear();
            txtbxSecond.Clear();
            txtbxResult.Clear();
            }
            catch { };
         
        }
    }
}
