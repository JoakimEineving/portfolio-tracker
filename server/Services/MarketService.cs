
namespace StocksApi.Services
{
    public class MarketService : IMarketService
    {
        private static List<MarketItem> marketOverviewGainers = new List<MarketItem>
        {
            new MarketItem
            {
                Symbol = "NXTP",
                Name = "NextPlay Technologies, Inc.",
                Change = 1.825m,
                Price = 2.73m,
                ChangesPercentage = 201.6575m
            },
            new MarketItem
            {
                Symbol = "ZJYL",
                Name = "Jin Medical International Ltd.",
                Change = 66.55m,
                Price = 137.03m,
                ChangesPercentage = 94.4239m
            },
            new MarketItem
            {
                Symbol = "DSKE",
                Name = "Daseke, Inc.",
                Change = 3.19m,
                Price = 8.1m,
                ChangesPercentage = 64.9695m
            }
        };
        private static List<MarketItem> marketOverviewLosers = new List<MarketItem>
        {
            new MarketItem
            {
                Symbol = "ALVR",
                Name = "AlloVir, Inc.",
                Change = -1.5646m,
                Price = 0.7654m,
                ChangesPercentage = -67.1502m
            },
            new MarketItem
            {
                Symbol = "JYD",
                Name = "Jayud Global Logistics Limited",
                Change = -1.5m,
                Price = 1.28m,
                ChangesPercentage = -53.9568m
            },
            new MarketItem
            {
                Symbol = "BRLI",
                Name = "Brilliant Acquisition Corporation",
                Change = -3.98m,
                Price = 4.7m,
                ChangesPercentage = -45.8525m
            }
        };

        public List<MarketItem> GetMarketGainers()
        {
            return marketOverviewGainers;
        }
        public List<MarketItem> GetMarketLosers()
        {
            return marketOverviewLosers;
        }

        
    }
}
