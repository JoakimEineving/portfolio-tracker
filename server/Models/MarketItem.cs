namespace StocksApi.Models
{
    public class MarketItem
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Change { get; set; }
        public decimal Price { get; set; }
        public decimal ChangesPercentage { get; set; }
    }
}
