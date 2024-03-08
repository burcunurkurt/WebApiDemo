using BurcunurKurt.WebApiDemo.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BurcunurKurt.WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController:Controller
    {
        readonly IProductDal _productDal;
        public ProductsController(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [HttpGet("GetString")]
        public IActionResult Get()
        {
            var products=_productDal.GetList();
            return Ok(products);
        }
    }
}
