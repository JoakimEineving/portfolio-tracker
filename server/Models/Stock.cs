namespace StocksApi.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public DateTime DatePurchased { get; set; } = DateTime.Now;

    }
    public class StockUpdate
    {
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public DateTime DatePurchased { get; set; }
    } 
}
