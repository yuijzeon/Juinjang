using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProductPrice.Core;
using ProductPrice.Database;

namespace ProductPrice.Forms
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource;
        private readonly IEnumerable<Product> _dataSource;
        private readonly IRepository _repository;

        public Form1()
        {
            _repository = new Repository();
            InitializeComponent();
            _dataSource = _repository.GetProducts().ToList();
            _bindingSource = new BindingSource { DataSource = _dataSource };
            dataGridView.DataSource = _bindingSource;
        }

        private Product ProductFromEditArea
        {
            get
            {
                try
                {
                    return new Product
                    {
                        Id = int.Parse(labelProductId.Text),
                        Name = textBoxProductName.Text,
                        Price = int.Parse(textBoxProductPrice.Text)
                    };
                }
                catch (Exception)
                {
                    MessageBox.Show("價格必須是數字");
                }

                return null;
            }
        }

        internal void AddProduct(Product product)
        {
            _repository.Add(product);
            _bindingSource.Add(product);
            _bindingSource.ResetBindings(true);
        }

        internal void NewProductButton(bool enable)
        {
            buttonNewProduct.Enabled = enable;
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            var f2 = new Form2(this);
            f2.Show();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定刪除此筆資料?", "確定刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var product = GetFromCurrentRow<Product>();
            _repository.Remove(product);
            _bindingSource.RemoveCurrent();
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            var single = _dataSource.Single(x => x.Id == ProductFromEditArea.Id);
            single.Name = ProductFromEditArea.Name;
            single.Price = ProductFromEditArea.Price;
            _bindingSource.ResetBindings(true);
            _repository.Update(ProductFromEditArea);
        }

        private T GetFromCurrentRow<T>() where T : new()
        {
            var currentRowIndex = dataGridView.CurrentRow?.Index;

            if (currentRowIndex == null)
            {
                return new T();
            }

            var dataBoundItem = (T)dataGridView.Rows[(int)currentRowIndex].DataBoundItem;

            return dataBoundItem == null
                ? new T()
                : dataBoundItem;
        }

        private void dataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            var product = GetFromCurrentRow<Product>();
            labelProductId.Text = product.Id.ToString();
            textBoxProductName.Text = product.Name;
            textBoxProductPrice.Text = product.Price.ToString();
        }

        private void buttonGoFirst_Click(object sender, EventArgs e)
        {
            //first
        }

        private void buttonGoPrevious_Click(object sender, EventArgs e)
        {
            //pre
        }

        private void buttonGoNext_Click(object sender, EventArgs e)
        {
            //next
        }

        private void buttonGoEnd_Click(object sender, EventArgs e)
        {
            //last
        }
    }
}