using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oval_Measure
{
    public partial class Form2 : Form
    {
        public int Value { get; set; }

        public Form2(string text = null)
        {
            InitializeComponent();
            label1.Text = text ?? public_Form2.public_Text;
        }

        // private void Form2_Load(object sender, EventArgs e)
        // {
        //     label1.Text = public_Form2.public_Text;
        // }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && int.TryParse(textBox1.Text, out var value))
            {
                Value = value;
                Close();
            }
        }
    }
}
