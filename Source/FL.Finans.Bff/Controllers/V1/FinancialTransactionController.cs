using FL.Finans.Bff.Controllers.Base;
using FL.Model;
using Microsoft.AspNetCore.Mvc;

namespace FL.Finans.Bff.Controllers.V1
{
    [Route("api/[controller]")]
    public class FinancialTransactionController : BaseController
    {

        /// <summary>
        /// Get a Financial Transaction by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetFinancialTransaction/{id:int}")]
        public async Task<ActionResult<FinancialTransaction>> Get(int id)
        {
            var output = await GetById<FinancialTransaction>("GetFinancialTransaction/", id);

            return Ok(output);
        }

    }
}
