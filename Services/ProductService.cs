using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WarehouseManagementSystem.Database;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Services
{
    public class ProductService
    {
        private readonly DbConnection dbConnection = new DbConnection();

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            ProductID = Convert.ToInt32(reader["ProductID"]),
                            SKU = reader["SKU"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Category = reader["Category"].ToString(),
                            QuantityInStock = Convert.ToInt32(reader["QuantityInStock"]),
                            ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]),
                            UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                            SupplierID = reader["SupplierID"] == DBNull.Value ? null : Convert.ToInt32(reader["SupplierID"]),
                            LocationID = reader["LocationID"] == DBNull.Value ? null : Convert.ToInt32(reader["LocationID"])
                        };

                        products.Add(product);
                    }
                }
            }

            return products;
        }

        public void AddProduct(Product product)
        {
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Products 
                                (SKU, ProductName, Category, QuantityInStock, ReorderLevel, UnitPrice) 
                                VALUES 
                                (@SKU, @ProductName, @Category, @QuantityInStock, @ReorderLevel, @UnitPrice)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SKU", product.SKU);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@QuantityInStock", product.QuantityInStock);
                cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
                cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                string query = @"UPDATE Products 
                                 SET SKU = @SKU,
                                     ProductName = @ProductName,
                                     Category = @Category,
                                     QuantityInStock = @QuantityInStock,
                                     ReorderLevel = @ReorderLevel,
                                     UnitPrice = @UnitPrice
                                 WHERE ProductID = @ProductID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                cmd.Parameters.AddWithValue("@SKU", product.SKU);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@QuantityInStock", product.QuantityInStock);
                cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
                cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int productId)
        {
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}