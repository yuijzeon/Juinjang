using System;
using System.Collections.Generic;
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

        internal void AddProduct(Product product)
        {
            bindingSource.Add(product);
            bindingSource.ResetBindings(true);
        }

        internal void NewProductButton(bool enable)
        {
            button5.Enabled = enable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var f2 = new Form2(this);

            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var ans = MessageBox.Show("確定刪除此筆資料?", "確定刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }
    }
}