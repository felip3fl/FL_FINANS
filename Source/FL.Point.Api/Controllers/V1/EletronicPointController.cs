using FL.Model;
using FL.Point.Api.Controllers.Base;
using FL.Point.Data.Inferfaces;
using FL.Point.Data.Repositories;
using FL.Point.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;

namespace FL.Point.Api.Controllers.V1
{
    /// <summary>
    /// This is the financial transaction controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EletronicPointController : BaseController
    {
        #region Properties

        protected readonly IEletronicPointRepository _pointRepository;

        #endregion

        public EletronicPointController(IEletronicPointRepository pointRepository)
        {
            _pointRepository = pointRepository;
        }

        #region Methods

        /// <summary>
        /// Create a eletronic point / Mark point
        /// </summary>
        /// <param name="eletronicPoint"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Update(EletronicPoint eletronicPoint)
        {
            await _pointRepository.Add(eletronicPoint);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _pointRepository.GetAll();

            return Ok(result);
        }

        #endregion
    }
}
