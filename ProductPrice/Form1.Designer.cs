namespace ProductPrice
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGoFirst = new System.Windows.Forms.Button();
            this.buttonGoPrevious = new System.Windows.Forms.Button();
            this.buttonGoNext = new System.Windows.Forms.Button();
            this.buttonGoEnd = new System.Windows.Forms.Button();
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 38;
            this.dataGridView.Size = new System.Drawing.Size(807, 481);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CurrentCellChanged += new System.EventHandler(this.dataGridView_CurrentCellChanged);
            // 
            // buttonGoFirst
            // 
            this.buttonGoFirst.Location = new System.Drawing.Point(99, 605);
            this.buttonGoFirst.Name = "buttonGoFirst";
            this.buttonGoFirst.Size = new System.Drawing.Size(112, 34);
            this.buttonGoFirst.TabIndex = 1;
            this.buttonGoFirst.Text = "第一筆";
            this.buttonGoFirst.UseVisualStyleBackColor = true;
            this.buttonGoFirst.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonGoPrevious
            // 
            this.buttonGoPrevious.Location = new System.Drawing.Point(232, 605);
            this.buttonGoPrevious.Name = "buttonGoPrevious";
            this.buttonGoPrevious.Size = new System.Drawing.Size(119, 34);
            this.buttonGoPrevious.TabIndex = 1;
            this.buttonGoPrevious.Text = "上一筆";
            this.buttonGoPrevious.UseVisualStyleBackColor = true;
            this.buttonGoPrevious.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonGoNext
            // 
            this.buttonGoNext.Location = new System.Drawing.Point(370, 605);
            this.buttonGoNext.Name = "buttonGoNext";
            this.buttonGoNext.Size = new System.Drawing.Size(119, 34);
            this.buttonGoNext.TabIndex = 1;
            this.buttonGoNext.Text = "下一筆";
            this.buttonGoNext.UseVisualStyleBackColor = true;
            this.buttonGoNext.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonGoEnd
            // 
            this.buttonGoEnd.Location = new System.Drawing.Point(517, 605);
            this.buttonGoEnd.Name = "buttonGoEnd";
            this.buttonGoEnd.Size = new System.Drawing.Size(119, 34);
            this.buttonGoEnd.TabIndex = 1;
            this.buttonGoEnd.Text = "最後一筆";
            this.buttonGoEnd.UseVisualStyleBackColor = true;
            this.buttonGoEnd.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Location = new System.Drawing.Point(907, 373);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(106, 41);
            this.buttonNewProduct.TabIndex = 1;
            this.buttonNewProduct.Text = "新增";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Location = new System.Drawing.Point(907, 277);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(106, 44);
            this.buttonUpdateProduct.TabIndex = 1;
            this.buttonUpdateProduct.Text = "更新";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(1029, 277);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(106, 44);
            this.buttonDeleteProduct.TabIndex = 1;
            this.buttonDeleteProduct.Text = "刪除";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(960, 183);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(127, 36);
            this.textBoxProductName.TabIndex = 2;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(960, 108);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(127, 36);
            this.textBoxProductPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(888, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "價錢:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(888, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "品名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "產品編號:";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(997, 55);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(64, 24);
            this.labelProductId.TabIndex = 4;
            this.labelProductId.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "匯出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonUpdateProduct);
            this.Controls.Add(this.buttonNewProduct);
            this.Controls.Add(this.buttonGoEnd);
            this.Controls.Add(this.buttonGoNext);
            this.Controls.Add(this.buttonGoPrevious);
            this.Controls.Add(this.buttonGoFirst);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonGoFirst;
        private System.Windows.Forms.Button buttonGoPrevious;
        private System.Windows.Forms.Button buttonGoNext;
        private System.Windows.Forms.Button buttonGoEnd;
        private System.Windows.Forms.Button buttonNewProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Button button1;
    }
}

