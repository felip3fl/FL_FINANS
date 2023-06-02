using FL.Point.Bff.Controllers.Base;
using FL.Model;
using Microsoft.AspNetCore.Mvc;
using FL.Point.Model;

namespace FL.Point.Bff.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class EletronicPointController : BaseController
    {

        public EletronicPointController(HttpClient httpClient) : base (httpClient) 
        { 

        }

        /// <summary>
        /// Get a Financial Transaction by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get/{id:int}")]
        public async Task<ActionResult<EletronicPoint>> Get(int id)
        {
            var output = await GetById<EletronicPoint>("GetFinancialTransaction/", id);

            return Ok(output);
        }

        [HttpGet]
        public async Task<ActionResult<EletronicPoint>> GetAll()
        {
            var output = await Get<EletronicPoint>("");

            return Ok(output);
        }

        /// <summary>
        /// Save the transaction
        /// </summary>
        /// <param name="EletronicPoint"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Update(EletronicPoint financialTransaction)
        {
            var output = await PostAsync<EletronicPoint>("GetFinancialTransaction/", financialTransaction);

            return Ok(output);
        }

    }
}
