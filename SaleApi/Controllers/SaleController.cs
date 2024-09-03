using ApplicationTier.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace SaleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleMethods _saleMethods;

        public SaleController(ISaleMethods saleMethods)
        {
            _saleMethods = saleMethods;
        }

        [HttpPost("AddSale", Name = "Add Sale")]
        public async Task<JsonResult> AddSale(int customerId, int storeId, int productId, string dateSoldString)
        {
            var sale = await _saleMethods.AddSale(customerId, productId, storeId, dateSoldString);

            return new JsonResult(sale);
        }
    }
}
