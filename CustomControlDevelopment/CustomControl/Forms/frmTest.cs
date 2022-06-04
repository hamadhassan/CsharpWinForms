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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        private void frmTest_Load(object sender, EventArgs e)
        {
        }

        private void cuTimer1_Load_1(object sender, EventArgs e)
        {
            cuTimer1.Interval = 100;
        }

        private void cuComboBox1_AddItemIntoList(object sender, EventArgs e)
        {
            cuComboBox1.Item = "Ali";
            List<string> a = new List<string>();
            a.Add("1");
            a.Add("2");
            cuComboBox1.addItems(a);
            cuComboBox1.Index = 0;
        }
    }
}
