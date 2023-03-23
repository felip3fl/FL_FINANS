using FL.Finans.Api.Controllers.Base;
using FL.Model;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace FL.Finans.Api.Controllers.V1
{
    public class FinancialTransactionController : BaseController
    {

        #region Methods

        public async Task<ActionResult<List<String>>> GetAll()
        {
            var transaction = new FinancialTransaction();

            return default;
        }

        public async Task<ActionResult<List<String>>> Get()
        {
            var transaction = new FinancialTransaction();

            return default;
        }


        public async Task<ActionResult<List<String>>> Post()
        {
            var transaction = new FinancialTransaction();

            return default;
        }

        public async Task<ActionResult<List<String>>> Put()
        {
            var transaction = new FinancialTransaction();

            return default;
        }

        #endregion
    }
}
