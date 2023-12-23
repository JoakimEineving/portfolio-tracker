namespace StocksApi.Models
{
    public class StockQuote
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ChangesPercentage { get; set; }
        public decimal Change { get; set; }
        public decimal DayLow { get; set; }
        public decimal DayHigh { get; set; }
        public decimal YearHigh { get; set; }
        public decimal YearLow { get; set; }
        public long MarketCap { get; set; }
        public decimal PriceAvg50 { get; set; }
        public decimal PriceAvg200 { get; set; }
        public string Exchange { get; set; }
        public long Volume { get; set; }
        public long AvgVolume { get; set; }
        public decimal Open { get; set; }
        public decimal PreviousClose { get; set; }
        public decimal Eps { get; set; }
        public decimal Pe { get; set; }
        public DateTime EarningsAnnouncement { get; set; }
        public long SharesOutstanding { get; set; }
        public long Timestamp { get; set; }
    }
}
