using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControl.BL;
using CustomControl.DL;

namespace CustomControl
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void cuTimer1_Load_1(object sender, EventArgs e)
        {
            cuTimer1.Interval = 100;
        }

        private void cuComboBox1_AddItemIntoList(object sender, EventArgs e)
        {
            //cuComboBox1.Item = "Ali";
            cuComboBox1.Index = 0;
            List<string> a = new List<string>();
            a.Add("1");
            a.Add("2");
            cuComboBox1.addItems(a);
        }
        private void frmTest_Load(object sender, EventArgs e)
        {
            MUser user = new MUser("aliahmed","hassan","admin");
            MUserDL.setIntoMUserList(user);
            user = new MUser();
            MUserDL.setIntoMUserList(user);
            datagv.DataSource = MUserDL.getMuserlist();
        }
        public void dataBind()
        {
            datagv.DataSource = null;
            datagv.DataSource = MUserDL.getMuserlist();
            datagv.Refresh();
        }
        private void datagv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MUser user = (MUser)datagv.CurrentRow.DataBoundItem;
            //if (0 == e.ColumnIndex)
            //{
            //    MUserDL.deletFromList(user);
            //   // dataBind();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datagv.SelectedRows.Count > 0)
            {
                datagv.Rows.RemoveAt(datagv.SelectedRows[0].Index);
            }
        }

        private void cuDataGrideView1_Delete(object sender, EventArgs e)
        {
            cuDataGrideView1.deleteSelectedRow(datagv);
        }

        private void cuDataGrideView1_Search(object sender, EventArgs e)
        {
            if (cuDataGrideView1.SearchUsername())
            {
                MessageBox.Show("Available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
