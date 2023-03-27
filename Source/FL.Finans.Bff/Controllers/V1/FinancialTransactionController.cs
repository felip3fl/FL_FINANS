using FL.Finans.Bff.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace FL.Finans.Bff.Controllers.V1
{
    public class FinancialTransactionController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
