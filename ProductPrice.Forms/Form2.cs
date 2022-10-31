using ProductPrice.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPrice.Forms
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            form1.NewProductButton(false);
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("確定新增此筆資料?", "確定新增",
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
