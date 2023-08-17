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
        [ProducesResponseType(typeof(ActionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Update(EletronicPoint eletronicPoint)
        {
            await _pointRepository.Add(eletronicPoint);

            return Ok();
        }

        /// <summary>
        /// Get all EletronicPoint Transaction
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<EletronicPoint>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<EletronicPoint>>> Get()
        {
            var result = await _pointRepository.GetAll();

            return Ok(result);
        }

        ///// <summary>
        ///// Get a Financial Transaction by Id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpGet("GetFinancialTransaction/{id:int}")]
        //[ProducesResponseType(typeof(FinancialTransaction), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<ActionResult<FinancialTransaction>> Get(int id)
        //{
        //    return await _financialTransactionRepository.GetById(id);
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="financialTransaction"></param>
        ///// <returns></returns>
        //[HttpPut]
        //public async Task<ActionResult<List<String>>> Put(FinancialTransaction financialTransaction)
        //{
        //    var transaction = new FinancialTransaction();

        //    if (transaction == null)
        //        AdicionarErroProcessamento("Erro - Objeto vazio");

        //    return CustomResponse();
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="financialTransaction"></param>
        ///// <returns></returns>
        //[HttpDelete]
        //public async Task<ActionResult<List<String>>> Delete(FinancialTransaction financialTransaction)
        //{
        //    var transaction = new FinancialTransaction();

        //    if (transaction == null)
        //        AdicionarErroProcessamento("Erro - Objeto vazio");

        //    return CustomResponse();
        //}


        ///// <summary>
        ///// Save the transaction
        ///// </summary>
        ///// <param name="financialTransaction"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public async Task<ActionResult> Update(FinancialTransaction financialTransaction)
        //{
        //    if (financialTransaction.Id == "")
        //        AdicionarErroProcessamento("Erro - Objeto financialTransaction vazio");

        //    return CustomResponse(); ;
        //}

        #endregion
    }
}
