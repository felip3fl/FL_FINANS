using FL.Data.Inferfaces;
using FL.Finans.Api.Controllers.Base;
using FL.Model;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace FL.Finans.Api.Controllers.V1
{
    /// <summary>
    /// This is the financial transaction controller
    /// </summary>
    [Route("api/[controller]")]
    public class FinancialTransactionController : BaseController
    {

        #region Properties

        protected readonly IFinancialTransactionRepository _financialTransactionRepository;

        #endregion

        #region Constructor
        
        public FinancialTransactionController(IFinancialTransactionRepository financialTransactionRepository)
        {
            _financialTransactionRepository = financialTransactionRepository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get all Financial Transaction
        /// </summary>
        /// <returns></returns>
        [HttpGet( "GetAllFinancialTransactions")]
        [ProducesResponseType(typeof(List<FinancialTransaction>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<FinancialTransaction>>> GetAll()
        {
            return await _financialTransactionRepository.GetAll();
        }

        /// <summary>
        /// Get a Financial Transaction by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetFinancialTransaction/{id:int}")]
        [ProducesResponseType(typeof(FinancialTransaction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<FinancialTransaction>> Get(int id)
        {
            return await _financialTransactionRepository.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="financialTransaction"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult<List<String>>> Put(FinancialTransaction financialTransaction)
        {
            var transaction = new FinancialTransaction();

            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="financialTransaction"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ActionResult<List<String>>> Delete(FinancialTransaction financialTransaction)
        {
            var transaction = new FinancialTransaction();

            return default;
        }


        /// <summary>
        /// Save the transaction
        /// </summary>
        /// <param name="financialTransaction"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Update(FinancialTransaction financialTransaction)
        {
            return Ok(); ;
        }

        #endregion
    }
}
