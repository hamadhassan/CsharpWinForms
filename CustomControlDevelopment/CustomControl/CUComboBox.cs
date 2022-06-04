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
    public partial class CUComboBox : UserControl
    {
        private string item;
        private int index;
        public event EventHandler AddItemIntoList;
        public CUComboBox()
        {
            InitializeComponent();
        }

        public string Item { get => item; set => item = value; }
        public int Index { get => index; set => index = value; }

        #region Custom Event
        public void OnAddItemIntoList(EventArgs e)
        {
            AddItemIntoList?.Invoke(this, e);
        }

        #endregion

        #region Add Item and Item 
        public void addItems(List<string> itemList)
        {
            foreach(string item in itemList)
            {
                cmbxList.Items.Add(item); 
            }
        }
        private void addItem()
        {
            if (item != string.Empty)
            {
                cmbxList.Items.Add(item);
            }
        }
        #endregion

        #region Add textBox text into list 
        private void cmbxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxList != null)
            {
                txtbxSelected.Clear();
                txtbxSelected.Text = cmbxList.SelectedItem.ToString();
            }
        }
        #endregion

        #region LoadEvent 
        private void CUComboBox_Load(object sender, EventArgs e)
        {
            OnAddItemIntoList(EventArgs.Empty);
            addItem();
            cmbxList.SelectedIndex = index;
        }
        #endregion

        #region  Leave Event 
        private void txtbxSelected_Leave(object sender, EventArgs e)
        {
            if (txtbxSelected.Text != string.Empty)
            {
                //foreach(string item in cmbxList.t)
                //{
                //    if (item != txtbxSelected.Text)
                //    {
                        string text = txtbxSelected.Text;
                        cmbxList.Items.Add(text);
                //    }
                //}
               
            }
        }
        #endregion
    }
}
