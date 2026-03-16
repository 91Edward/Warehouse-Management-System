namespace WarehouseManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            btnLoadProducts = new Button();
            SKU = new Label();
            ProductName = new Label();
            Category = new Label();
            QuantityInStock = new Label();
            ReorderLevel = new Label();
            UnitPrice = new Label();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            btnClear = new Button();
            txtSKU = new TextBox();
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtQuantityInStock = new TextBox();
            txtReorderLevel = new TextBox();
            txtUnitPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(263, 9);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1174, 414);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnLoadProducts
            // 
            btnLoadProducts.Location = new Point(-2, 260);
            btnLoadProducts.Name = "btnLoadProducts";
            btnLoadProducts.Size = new Size(127, 29);
            btnLoadProducts.TabIndex = 1;
            btnLoadProducts.Text = "Load Products";
            btnLoadProducts.UseVisualStyleBackColor = true;
            btnLoadProducts.Click += btnLoadProducts_Click;
            // 
            // SKU
            // 
            SKU.AutoSize = true;
            SKU.Location = new Point(12, 9);
            SKU.Name = "SKU";
            SKU.Size = new Size(36, 20);
            SKU.TabIndex = 2;
            SKU.Text = "SKU";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(-2, 47);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(104, 20);
            ProductName.TabIndex = 3;
            ProductName.Text = "Product Name";
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(-2, 87);
            Category.Name = "Category";
            Category.Size = new Size(69, 20);
            Category.TabIndex = 4;
            Category.Text = "Category";
            // 
            // QuantityInStock
            // 
            QuantityInStock.AutoSize = true;
            QuantityInStock.Location = new Point(-2, 134);
            QuantityInStock.Name = "QuantityInStock";
            QuantityInStock.Size = new Size(121, 20);
            QuantityInStock.TabIndex = 5;
            QuantityInStock.Text = "Quantity in Stock";
            // 
            // ReorderLevel
            // 
            ReorderLevel.AutoSize = true;
            ReorderLevel.Location = new Point(-2, 178);
            ReorderLevel.Name = "ReorderLevel";
            ReorderLevel.Size = new Size(100, 20);
            ReorderLevel.TabIndex = 6;
            ReorderLevel.Text = "Reorder Level";
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSize = true;
            UnitPrice.Location = new Point(-2, 222);
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Size = new Size(72, 20);
            UnitPrice.TabIndex = 7;
            UnitPrice.Text = "Unit Price";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(-2, 295);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(127, 29);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(-2, 330);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(127, 29);
            btnUpdateProduct.TabIndex = 9;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(-2, 365);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(127, 29);
            btnDeleteProduct.TabIndex = 10;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(-2, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(132, 2);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(125, 27);
            txtSKU.TabIndex = 12;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(132, 40);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 13;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(132, 80);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 14;
            // 
            // txtQuantityInStock
            // 
            txtQuantityInStock.Location = new Point(132, 127);
            txtQuantityInStock.Name = "txtQuantityInStock";
            txtQuantityInStock.Size = new Size(125, 27);
            txtQuantityInStock.TabIndex = 15;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(132, 175);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(125, 27);
            txtReorderLevel.TabIndex = 16;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(132, 215);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 450);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtReorderLevel);
            Controls.Add(txtQuantityInStock);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Controls.Add(txtSKU);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(UnitPrice);
            Controls.Add(ReorderLevel);
            Controls.Add(QuantityInStock);
            Controls.Add(Category);
            Controls.Add(ProductName);
            Controls.Add(SKU);
            Controls.Add(btnLoadProducts);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnLoadProducts;
        private Label SKU;
        private Label ProductName;
        private Label Category;
        private Label QuantityInStock;
        private Label ReorderLevel;
        private Label UnitPrice;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Button btnClear;
        private TextBox txtSKU;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtQuantityInStock;
        private TextBox txtReorderLevel;
        private TextBox txtUnitPrice;
    }
}
