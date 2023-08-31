using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public string GetProducts()
        {
            return "my list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "my product";
        }
    }
}
