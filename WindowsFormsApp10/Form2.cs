using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private Product myVar;
        public DialogResult Result { get; set; }
        public Product MyProduct
        {
            get { return myVar; }
            set
            {
                if (myVar is null)
                {
                    txtName.Text = value.ProductName;
                    txtCountry.Text = value.ProductOriginCountry;
                    txtCost.Text = $"{value.ProductCost}";
                }
                myVar = value;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length >= 3)
            {
                if (txtCountry.Text.Length >= 3)
                {
                    DialogResult = DialogResult.OK;
                    MyProduct = new Product(txtName.Text, txtCountry.Text, Convert.ToInt32(txtCost.Text));
                }
                else
                    MessageBox.Show("Product Country Length Must be Greate Or Equal to Three");
            }
            else
                MessageBox.Show("Product Name Length Must be Greate Or Equal to Three");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCost.Text))
                    Convert.ToInt32(txtCost.Text);

            }
            catch
            {
                txtCost.Text = txtCost.Text.Substring(0, txtCost.Text.Length - 1); ;
                txtCost.SelectionStart = txtCost.Text.Length;
            }
        }
    }
}
