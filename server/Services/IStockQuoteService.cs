namespace StocksApi.Services
{
    public interface IStockQuoteService
    {
        StockQuote GetStockQuote(string symbol);
    }
}
