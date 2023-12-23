
namespace StocksApi.Services
{
    public class StockService : IStockService
    {
        private static List<Stock> stocks = new List<Stock>
        {
            new Stock
                {
                    Id = 1,
                    Symbol = "AAPL",
                    PurchasePrice = 150.00m,
                    Quantity = 10,
                },
            new Stock
                {
                    Id = 2,
                    Symbol = "IBM",
                    PurchasePrice = 160.00m,
                    Quantity = 5,
                }
        };
        public List<Stock> AddStock(Stock stock)
        {
            stocks.Add(stock);

            return stocks;
        }

        public Stock? DeleteStock(int id)
        {
            var stock = stocks.Find(x => x.Id == id);
            if (stock is null)
            {
                return null;
            }

            stocks.Remove(stock);

            return stock;
        }

        public List<Stock> GetAllStocks()
        {
            return stocks;
        }

        public Stock? GetStockById(int id)
        {
            var stock = stocks.Find(x => x.Id == id);
            if (stock is null)
            {
                return null;
            }
            return stock;
        }

        public Stock? UpdateStock(int id, StockUpdate request)
        {
            var stock = stocks.Find(x => x.Id == id);
            if (stock is null)
            {
                return null;
            }

            stock.PurchasePrice = request.PurchasePrice;
            stock.Quantity = request.Quantity;
            stock.DatePurchased = request.DatePurchased;

            return stock;
        }
    }
}
