using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductPrice.Core;

namespace ProductPrice.Forms
{
    public partial class Form1 : Form
    {
        public BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
            bindingSource = new BindingSource { DataSource = new List<Product>() };
            dataGridView1.DataSource = bindingSource;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);

            f2.Show();
        }

        internal void AddProduct(Product product)
        {
            bindingSource.Add(product);
            bindingSource.ResetBindings(true);
        }
        internal void NewProductButton(bool enable)
        {
            button5.Enabled = enable;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("確定刪除此筆資料?", "確定刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
            }
            }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}