namespace AdoDapperBLL.DTO.Responses
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public string? Image { get; set; }
        public string Name { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public string Description { get; set; } = null!;

        public string SupplierCompanyName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
    }
}
