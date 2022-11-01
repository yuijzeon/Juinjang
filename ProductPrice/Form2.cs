using System;
using System.Windows.Forms;

namespace ProductPrice
{
    public partial class Form2 : Form
    {
        private readonly Form1 _form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            form1.NewProductButton(false);
            _form1 = form1;
        }

        private string InputId => textBox1.Text;
        private string InputName => textBox2.Text;
        private string InputPrice => textBox3.Text;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(InputPrice, out var price))
            {
                MessageBox.Show(@"產品價格必須為數字", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var ans = MessageBox.Show(@"確定新增此筆資料?", @"確定新增", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ans == DialogResult.Yes)
                {
                    _form1.AddProduct(new Product(InputName, price));
                }

                _form1.NewProductButton(true);
                Close();
            }
        }
    }
}