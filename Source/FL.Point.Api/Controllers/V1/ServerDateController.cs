using FL.Point.Api.Controllers.Base;
using FL.Point.Model;
using Microsoft.AspNetCore.Mvc;

namespace FL.Point.Api.Controllers.V1
{
    /// <summary>
    /// This is the Serve Daten controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ServerDateController : BaseController
    {

        #region Methods

        /// <summary>
        /// Get current Date from server
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(DateTime), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DateTime>> Get()
        {
            var result = DateTime.Now;

            return Ok(result);
        }

        #endregion
    }
}
