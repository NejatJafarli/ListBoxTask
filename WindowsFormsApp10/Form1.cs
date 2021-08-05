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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            while (listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.Items[0]);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form2.MyProduct);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                Form2 form2 = new Form2();
                form2.MyProduct = listBox1.SelectedItem as Product;
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items[listBox1.Items.IndexOf(listBox1.SelectedItem)] = form2.MyProduct;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <= 0)
            {
                guna2Button3.Enabled = false;
                guna2Button2.Enabled = false;
                guna2Button1.Enabled = false;
            }
            else
            {
                guna2Button3.Enabled = true;
                guna2Button2.Enabled = true;
                guna2Button1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
