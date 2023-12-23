namespace StocksApi.Services
{
    public interface IMarketService
    {
        List<MarketItem> GetMarketGainers();
        List<MarketItem> GetMarketLosers();
    }
}
