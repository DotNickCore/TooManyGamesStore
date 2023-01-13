using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace TooManyGamesStore.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<string> GetProducts()
        {
            try
            {
                return Ok(JsonSerializer.Serialize(""));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<string> GetProduct(int id)
        {
            try
            {
                return Ok(JsonSerializer.Serialize(""));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
