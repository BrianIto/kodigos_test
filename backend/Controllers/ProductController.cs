using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kodigos.Services;

namespace Kodigos.Controllers
{
    /// <summary>
    /// Controller for handling product-related requests.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    {
    private readonly ProductService _productService;
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="productService">The product service.</param>
                public ProductController(ProductService productService) {  
            _productService = productService;
        }

        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns>A list of products.</returns>
        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Ok(_productService.GetSomeMock());
        }
    }
}