using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kodigos.Services;

namespace Kodigos.Controllers
{
    /// <summary>
    /// Controller for handling rejections.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RejectionController: ControllerBase
    {

        private readonly RejectionService _rejectionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectionController"/> class.
        /// </summary>
        /// <param name="rejectionService">The rejection service.</param>
        public RejectionController(RejectionService rejectionService) {  
            _rejectionService = rejectionService;
        }
        /// <summary>
        /// Retrieves all rejections.
        /// </summary>
        /// <returns>A list of rejection.</returns>
        [HttpGet]
        public ActionResult<List<Rejection>> GetAll()
        {
            return Ok(_rejectionService.GetSomeMock());
        }

        /// <summary>
        ///  Creates a new rejection.
        ///  </summary>
        ///  <param name="rejection">The rejection to create.</param>
        ///  <returns>The created rejection.</returns>
        ///  <response code="200">Returns the created rejection</response>
        ///  <response code="400">If the rejection is invalid</response>
        ///  <response code="500">If there was an internal server error</response>
        [HttpPost]
        public ActionResult<List<Rejection>> Create(Rejection rejection)
        {
            return Ok(_rejectionService.Create(rejection));
        }


    }
}