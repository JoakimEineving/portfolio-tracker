using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StocksApi.Services;

namespace StocksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockQuoteController : ControllerBase
    {
        private readonly IStockQuoteService _stockQuoteService;
        private readonly IMarketService _marketService;

        public StockQuoteController(IStockQuoteService stockQuoteService, IMarketService marketService)
        {
            _stockQuoteService = stockQuoteService;
            _marketService = marketService;
        }

        [HttpGet("{symbol}")]
        public ActionResult<StockQuote> Get(string symbol)
        {
            var stockQuote = _stockQuoteService.GetStockQuote(symbol);
            if (stockQuote == null)
            {
                return NotFound();
            }
            return stockQuote;
        }
    }
}
