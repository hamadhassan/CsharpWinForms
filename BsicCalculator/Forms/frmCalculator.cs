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
    public partial class frmCalculatorBasic : Form
    {
        private double total;
        public frmCalculatorBasic()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblStoreResult.Text+=txtbxBasic.Text;
            txtbxBasic.Text = "";
            txtbxBasic.Focus();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMultipliy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClearOne_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            
         
        }

        private void txtbxBasic_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
