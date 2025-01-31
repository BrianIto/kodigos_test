using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kodigos.Services;

namespace Kodigos.Controllers
{
    /// <summary>
    /// Controller for value analysis operations
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValueAnalysisController: ControllerBase
    {

        private readonly ValueAnalysisService _valueAnalysisService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueAnalysisController"/> class.
        /// </summary>
        /// <param name="valueAnalysisService">The value analysis service.</param>
        public ValueAnalysisController(ValueAnalysisService valueAnalysisService) {  
            _valueAnalysisService = valueAnalysisService;
        }

        /// <summary>
        /// Get the first value analysis
        /// </summary>
        /// <returns>A value analysis to use as mock to render the webpage</returns>
        [HttpGet]
        public ActionResult<ValueAnalysis> GetFirst()
        {
            return Ok(_valueAnalysisService.GetMock());
        }

        /// <summary>
        /// Approve a value analysis
        /// </summary>
        /// <param name="id">The id of the value analysis to approve</param>
        /// <returns>The approved value analysis</returns>
        /// <response code="200">Returns the approved value analysis</response>
        /// <response code="404">If the value analysis is not found</response>
        /// <response code="400">If the value analysis is not in a pending state</response>
        /// 
        [HttpPost]
        [Route("approve")]
        public ActionResult<ValueAnalysis> Approve(int id)
        {
            if (id == 1 ) {
            var data = _valueAnalysisService.GetMock();
            data.status = Status.Approved;
            return Ok(data);
            } else if (id == 2) {
                return NotFound();
            } else {
                return BadRequest();
            }
        }
    }
}