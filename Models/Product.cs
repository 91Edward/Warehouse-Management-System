namespace WarehouseManagementSystem.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int QuantityInStock { get; set; }
        public int ReorderLevel { get; set; }
        public decimal UnitPrice { get; set; }
        public int? SupplierID { get; set; }
        public int? LocationID { get; set; }
    }
}