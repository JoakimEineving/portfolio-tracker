using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StocksApi.Services;

namespace StocksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly IMarketService _MarketService;
        public MarketController(IMarketService MarketService)
        {
            _MarketService = MarketService;
        }

        [HttpGet("gainers")]
        public async Task<ActionResult<List<MarketItem>>> GetMarketGainers()
        {
            return Ok(_MarketService.GetMarketGainers());
        }

        [HttpGet("losers")]
        public async Task<ActionResult<List<MarketItem>>> GetMarketLosers()
        {
            return Ok(_MarketService.GetMarketLosers());
        }
    }
}
