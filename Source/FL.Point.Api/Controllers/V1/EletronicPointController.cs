using FL.Model;
using FL.Point.Api.Controllers.Base;
using FL.Point.Data.Inferfaces;
using FL.Point.Data.Repositories;
using FL.Point.GoogleCalendarApi;
using FL.Point.GoogleCalendarApi.Interfaces;
using FL.Point.GoogleCalendarApi.Services;
using FL.Point.Model;
using Microsoft.AspNetCore.Cors;
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
    [EnableCors("AllowOrigin")]
    public class EletronicPointController : BaseController
    {
        #region Properties

        protected readonly IEletronicPointRepository _pointRepository;
        private IGoogleCalendarService _googleCalendarService;

        #endregion

        public EletronicPointController(IEletronicPointRepository pointRepository, IGoogleCalendarService googleCalendarService)

        {
            _googleCalendarService = googleCalendarService;
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> Put()
        {
            var transaction = new EletronicPoint();

            if (transaction == null)
                AdicionarErroProcessamento("Erro - Objeto vazio");

            return CustomResponse();
        }

        /// <summary>
        /// Mark point / Create a new point
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Post()
        {
            var data = _googleCalendarService.AddToGoogleCalendar(calendarEventReqDTO, _authenticatorSettings.ClientID, _authenticatorSettings.ClientSecret);
            return Ok(data);
        }

        #endregion
    }
}
