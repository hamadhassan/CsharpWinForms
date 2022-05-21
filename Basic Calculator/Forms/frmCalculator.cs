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
        private double firstValue;
        private int count;
        private double result;
        public frmCalculatorBasic()
        {
            InitializeComponent();
        }
        #region Operation +,-,/,*
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstValue=double.Parse(txtbxBasic.Text);
            lblStoreResult.Text+=txtbxBasic.Text+"+";
            txtbxBasic.Text = "";
            txtbxBasic.Focus();
            count = 0;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(txtbxBasic.Text);
            lblStoreResult.Text += txtbxBasic.Text + "-";
            txtbxBasic.Text = "";
            txtbxBasic.Focus();
            count = 1;
        }

        private void btnMultipliy_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(txtbxBasic.Text);
            lblStoreResult.Text += txtbxBasic.Text + "*";
            txtbxBasic.Text = "";
            txtbxBasic.Focus();
            count = 2;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            firstValue = double.Parse(txtbxBasic.Text);
            lblStoreResult.Text += txtbxBasic.Text + "/";
            txtbxBasic.Text = "";
            txtbxBasic.Focus();
            count = 3;
        }
        #endregion

        #region Result
        private void btnEqualTo_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 0:
                    lblStoreResult.Text+=txtbxBasic.Text+"+";
                    result = firstValue + double.Parse(txtbxBasic.Text);
                    txtbxBasic.Text = result.ToString();
                    lblStoreResult.Text = "";
                    break;
                case 1:
                    result = firstValue - double.Parse(txtbxBasic.Text);
                    txtbxBasic.Text = result.ToString();
                    lblStoreResult.Text = "";
                    break;
                case 2:
                    result = firstValue * double.Parse(txtbxBasic.Text);
                    txtbxBasic.Text = result.ToString();
                    lblStoreResult.Text = "";
                    break;
                case 3:
                    result = firstValue / double.Parse(txtbxBasic.Text);
                    txtbxBasic.Text = result.ToString();
                    lblStoreResult.Text = "";
                    break;
            }

        }
        #endregion

        #region Button 0-9, .
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text = "";
            lblStoreResult.Text = "";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 0;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += 9;
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtbxBasic.Text += ".";
        }
        #endregion
    }
}
