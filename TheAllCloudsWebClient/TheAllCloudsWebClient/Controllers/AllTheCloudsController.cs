using Microsoft.AspNetCore.Mvc;
using TheAllCloudsWebClient.Services.Interfaces;

namespace TheAllCloudsWebClient.Controllers
{
    [Route("api/[controller]")]
    public class AllTheCloudsController : Controller
    {
        private IProductService _productService;
        public AllTheCloudsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("[action]")]
        public ActionResult Products()
        {
            return Ok(_productService.GetProducts());            
        }

    }
}
