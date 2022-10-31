using System;
using System.Windows.Forms;
using ProductPrice.Core;

namespace ProductPrice.Forms
{
    public partial class Form2 : Form
    {
        private readonly Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            form1.NewProductButton(false);
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ans = MessageBox.Show("確定新增此筆資料?", "確定新增",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == System.Windows.Forms.DialogResult.Yes)
            {
                form1.AddProduct(new Product(1, "aa", 10));
            }

            form1.NewProductButton(true);
            this.Close();
        }
    }
}