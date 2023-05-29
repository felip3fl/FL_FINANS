using FL.Model;
using FL.Point.Api.Controllers.Base;
using FL.Point.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;

namespace FL.Point.Api.Controllers.V1
{
    public class PointController : BaseController
    {
        #region Methods

        /// <summary>
        /// Mark point
        /// </summary>
        /// <param name="eletronicPoint"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Update(EletronicPoint eletronicPoint)
        {
            if (eletronicPoint.Id == "")
                AdicionarErroProcessamento("Erro - Objeto financialTransaction vazio");

            return CustomResponse();
        }

        #endregion
    }
}
