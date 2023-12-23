using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StocksApi.Services;

namespace StocksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {

        private readonly IStockService _stockService;
        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Stock>>> GetAllStocks()
        {
            return Ok(_stockService.GetAllStocks());
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Stock>> GetStockById(int id)
        {
            var result = _stockService.GetStockById(id);
            if (result is null)
            {
                return NotFound("Stock not found.");
            }
            return Ok(result);
        }

        [HttpPost]

        public async Task<ActionResult<List<Stock>>> AddStock(Stock stock)
        {
            var result = _stockService.AddStock(stock);
            return Ok(result);
        }
        
        [HttpPut("{id}")]

        public async Task<ActionResult<Stock>> UpdateStock(int id, StockUpdate request)
        {
            var result = _stockService.UpdateStock(id, request);
            if (result is null)
            {
                return NotFound("Stock not found.");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Stock>> DeleteStock(int id)
        {
            var result = _stockService.DeleteStock(id);
            if(result is null)
            {
                return NotFound("Stock not found.");
            }
            return Ok(result);
        }
    }
}
