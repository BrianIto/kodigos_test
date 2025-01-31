using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kodigos.Services;

namespace Kodigos.Controllers
{
        /// <summary>
    /// Controller for managing suppliers.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController: ControllerBase
    {

        private readonly SupplierService _supplierService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SupplierController"/> class.
        /// </summary>
        /// <param name="supplierService">The supplier service.</param>
        public SupplierController(SupplierService supplierService) {  
            _supplierService = supplierService;
        }
        /// <summary>
        /// Gets all suppliers.
        /// </summary>
        /// <returns>A list of suppliers.</returns>
        [HttpGet]
        public ActionResult<List<Supplier>> GetAll()
        {
            return Ok(_supplierService.GetSomeMock());
        }
    }
}