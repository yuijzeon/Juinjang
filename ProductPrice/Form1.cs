using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ProductPrice
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource;
        private readonly JuinjangContext _context;

        public Form1(JuinjangContext context)
        {
            _context = context;
            InitializeComponent();
            _bindingSource = new BindingSource { DataSource = context.Products.Local.ToBindingList() };
            dataGridView.DataSource = _bindingSource;
        }

        internal void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        internal void NewProductButton(bool enable)
        {
            buttonNewProduct.Enabled = enable;
        }

        private Product ProductFromEditArea() => new Product
        {
            Id = int.Parse(labelProductId.Text),
            Name = textBoxProductName.Text,
            Price = int.Parse(textBoxProductPrice.Text)
        };

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            var f2 = new Form2(this);
            f2.Show();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"確定刪除此筆資料?", @"確定刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var id = ProductFromEditArea().Id;
            var products = _context.Products.Where(x => x.Id == id);
            _context.Products.RemoveRange(products);
            _context.SaveChanges();
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            var myProduct = ProductFromEditArea();
            _context.Products.Single(x => x.Id == myProduct.Id).Rewrite(myProduct);
            _bindingSource.ResetBindings(false);
            _context.SaveChanges();
        }

        private void dataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            var product = GetCurrentProduct();
            labelProductId.Text = product.Id.ToString();
            textBoxProductName.Text = product.Name;
            textBoxProductPrice.Text = product.Price.ToString();
            label1.Text = $@"目前選擇第{_bindingSource.Position + 1}筆，共{_bindingSource.Count}筆資料";
        }

        private Product GetCurrentProduct()
        {
            try
            {
                return (Product)dataGridView.Rows[dataGridView.CurrentRow?.Index ?? 0].DataBoundItem;
            }
            catch
            {
                // ignored
            }

            return new Product();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case nameof(buttonGoFirst):
                    _bindingSource.MoveFirst();
                    break;
                case nameof(buttonGoPrevious):
                    _bindingSource.MovePrevious();
                    break;
                case nameof(buttonGoNext):
                    _bindingSource.MoveNext();
                    break;
                case nameof(buttonGoEnd):
                    _bindingSource.MoveLast();
                    break;
            }
        }
    }
}