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
    public partial class CUDataGrideView : UserControl
    {
        public event EventHandler Delete;
        public event EventHandler Search;
        public CUDataGrideView()
        {
            InitializeComponent();
        }
        #region Delete
        public void DeleteRow(EventArgs e)
        {
            Delete?.Invoke(this, e);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow(EventArgs.Empty);
        }
        public void deleteSelectedRow(DataGridView dataGrideView)
        {
            if (dataGrideView.SelectedRows.Count > 0)
            {
                dataGrideView.Rows.RemoveAt(dataGrideView.SelectedRows[0].Index);
            }
        }
        #endregion

        #region Search 
        private void SearchUsername_(EventArgs e)
        {
            Search?.Invoke(this, e);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUsername_(EventArgs.Empty);
        }
        public bool SearchUsername()
        {
            foreach(MUser m in MUserDL.getMuserlist())
            {
                if (m.Username == txtbxSearch.Text)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
