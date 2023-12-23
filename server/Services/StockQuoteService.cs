using System.Xml.Linq;

namespace StocksApi.Services
{
    public class StockQuoteService : IStockQuoteService
    {
        private static List<StockQuote> stockQuotes = new List<StockQuote>
{
    new StockQuote
    {
        Symbol = "AAPL",
        Name = "Apple Inc.",
        Price = 145.775m,
        ChangesPercentage = 0.32m,
        Change = 0.465m,
        DayLow = 143.9m,
        DayHigh = 146.71m,
        YearHigh = 179.61m,
        YearLow = 124.17m,
        MarketCap = 2306437439846,
        PriceAvg50 = 140.8724m,
        PriceAvg200 = 147.18594m,
        Exchange = "NASDAQ",
        Volume = 42478176,
        AvgVolume = 73638864,
        Open = 144.38m,
        PreviousClose = 145.31m,
        Eps = 5.89m,
        Pe = 24.75m,
        EarningsAnnouncement = DateTime.Parse("2023-04-26T10:59:00.000+0000"),
        SharesOutstanding = 15821899776,
        Timestamp = 1677790773
    },
    new StockQuote
    {
        Symbol = "IBM",
        Name = "International Business Machines Corporation",
        Price = 162.23m,
        ChangesPercentage = -0.4174m,
        Change = -0.68m,
        DayLow = 162.05m,
        DayHigh = 164.085m,
        YearHigh = 166.34m,
        YearLow = 120.55m,
        MarketCap = 148135295370,
        PriceAvg50 = 149.4818m,
        PriceAvg200 = 138.2706m,
        Exchange = "NYSE",
        Volume = 4625338,
        AvgVolume = 4275520,
        Open = 162.3m,
        PreviousClose = 162.91m,
        Eps = 7.75m,
        Pe = 20.93m,
        EarningsAnnouncement = DateTime.Parse("2024-01-23T00:00:00.000+0000"),
        SharesOutstanding = 913119000,
        Timestamp = 1702674002
    }
};

        public StockQuote GetStockQuote(string symbol)
        {
            var stockQuote = stockQuotes.Find(x => x.Symbol == symbol);
            if (stockQuote is null)
            {
                return null;
            }
            return stockQuote;
        }
    }
}
