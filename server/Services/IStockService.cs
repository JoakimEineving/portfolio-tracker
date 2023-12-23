namespace StocksApi.Services
{
    public interface IStockService
    {
        List<Stock> GetAllStocks();
        Stock GetStockById(int id);
        List<Stock> AddStock(Stock stock);
        Stock UpdateStock(int id, StockUpdate request);
        Stock DeleteStock(int id);
    }
}
