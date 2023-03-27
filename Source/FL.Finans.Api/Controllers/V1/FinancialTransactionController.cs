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
    public class FinancialTransactionController : BaseController
    {

        #region Properties

        protected readonly IFinancialTransactionRepository FinancialTransactionRepository;

        #endregion

        #region Methods

        /// <summary>
        /// Get all Financial Transaction
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAllFinancialTransactions")]
        [ProducesResponseType(typeof(List<FinancialTransaction>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<FinancialTransaction>>> GetAll()
        {
            return await FinancialTransactionRepository.GetAll();
        }

        /// <summary>
        /// Get a Financial Transaction by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id:int",Name = "GetFinancialTransaction")]
        [ProducesResponseType(typeof(FinancialTransaction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<FinancialTransaction>> Get(int id)
        {
            var transaction = new FinancialTransaction();

            return transaction;
        }


        public async Task<ActionResult<List<String>>> Put()
        {
            var transaction = new FinancialTransaction();

            return default;
        }


        /// <summary>
        /// Save the transaction
        /// </summary>
        /// <param name="financialTransaction"></param>
        /// <returns></returns>
        [HttpPost(Name = "Post")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Post(FinancialTransaction financialTransaction)
        {
            return Ok(); ;
        }

        #endregion
    }
}
