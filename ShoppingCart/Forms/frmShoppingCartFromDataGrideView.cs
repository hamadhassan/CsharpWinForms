using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingCart.BL;
using ShoppingCart.DL;

namespace ShoppingCart
{
    public partial class frmShoppingCartFromDataGrideView : Form
    {
        public frmShoppingCartFromDataGrideView()
        {
            InitializeComponent();
        }

        private void btnBind_Click(object sender, EventArgs e)
        {
            ShoppingCartBL shoppingCart = new ShoppingCartBL("abc", 123);
            ShoppingCartDL.setIntoShoppingList(shoppingCart);
            ShoppingCartDL.setIntoShoppingList(new ShoppingCartBL("aaaa", 1111));
            dataGridView1.DataSource = ShoppingCartDL.getShoppingList();
        }
    }
}
