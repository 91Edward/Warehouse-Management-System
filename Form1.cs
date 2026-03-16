using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.Services;

namespace WarehouseManagementSystem
{
    public partial class Form1 : Form
    {
        private readonly ProductService productService = new ProductService();
        private int selectedProductId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            try
            {
                List<Product> products = productService.GetAllProducts();
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtSKU.Text = "";
            txtProductName.Text = "";
            txtCategory.Text = "";
            txtQuantityInStock.Text = "";
            txtReorderLevel.Text = "";
            txtUnitPrice.Text = "";
            selectedProductId = 0;
        }

        private Product GetProductFromForm()
        {
            if (string.IsNullOrWhiteSpace(txtSKU.Text))
                throw new Exception("SKU is required.");

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
                throw new Exception("Product Name is required.");

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
                throw new Exception("Category is required.");

            if (!int.TryParse(txtQuantityInStock.Text.Trim(), out int quantityInStock))
                throw new Exception("Quantity In Stock must be a valid number.");

            if (!int.TryParse(txtReorderLevel.Text.Trim(), out int reorderLevel))
                throw new Exception("Reorder Level must be a valid number.");

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal unitPrice))
                throw new Exception("Unit Price must be a valid decimal number.");

            return new Product
            {
                ProductID = selectedProductId,
                SKU = txtSKU.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                QuantityInStock = quantityInStock,
                ReorderLevel = reorderLevel,
                UnitPrice = unitPrice
            };
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = GetProductFromForm();
                productService.AddProduct(product);
                MessageBox.Show("Product added successfully.");
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == 0)
                {
                    MessageBox.Show("Please select a product to update.");
                    return;
                }

                Product product = GetProductFromForm();
                productService.UpdateProduct(product);
                MessageBox.Show("Product updated successfully.");
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == 0)
                {
                    MessageBox.Show("Please select a product to delete.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    productService.DeleteProduct(selectedProductId);
                    MessageBox.Show("Product deleted successfully.");
                    LoadProducts();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
                txtSKU.Text = row.Cells["SKU"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtQuantityInStock.Text = row.Cells["QuantityInStock"].Value.ToString();
                txtReorderLevel.Text = row.Cells["ReorderLevel"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
            }
        }
    }
}