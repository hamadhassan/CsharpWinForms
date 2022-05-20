using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class frmShoppingCart : Form
    {
        public frmShoppingCart()
        {
            InitializeComponent();
        }
        private double grandTotal;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblRemoveShirt_Click(object sender, EventArgs e)
        {
            txtbxShirt.Clear();
        }

        private void lblRemoveShoes_Click(object sender, EventArgs e)
        {
            txtbxShoes.Clear();
        }

        private void lblRemovePaints_Click(object sender, EventArgs e)
        {
            txtbxPaints.Text = "0";
        }
        private void txtbxShirt_TextChanged(object sender, EventArgs e)
        {
            float quantity = int.Parse(txtbxShirt.Text);
            float price = int.Parse(lblShirt.Text);
            double total = quantity * price;
            lblShirtTotal.Text = Convert.ToString(total);
            lblTotal.Text = Convert.ToString(grandTotal+total);
        }

        private void txtbxShoes_TextChanged(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtbxShoes.Text);
            int price = int.Parse(lblShoes.Text);
            double total = quantity * price;
            lblShoesTotal.Text = Convert.ToString(total);
            lblTotal.Text = Convert.ToString(grandTotal + total);
        }

        private void txtbxPaints_TextChanged(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtbxPaints.Text);
            int price = int.Parse(lblPaints.Text);
            double total = quantity * price;
            lblPaintsTotal.Text = Convert.ToString(total);
            lblTotal.Text = Convert.ToString(grandTotal + total);

        }
    }
}
