using FL.Point.GoogleCalendarApi.Interfaces;
using FL.Point.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FL.Point.Api.Controllers.V1
{
    public class AuthorizationController : Controller
    {

        private IGoogleCalendarService _googleCalendarService;
        public AuthorizationController(IGoogleCalendarService googleCalendarService)

        {
            _googleCalendarService = googleCalendarService;
        }

        /// <summary>
        /// Use this to authenticate on Google account
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/auth/google")]
        public async Task<IActionResult> GoogleAuth()
        {
            return Redirect(_googleCalendarService.GetAuthCode("", ""));
        }

        /// <summary>
        /// If authenticate successfully, Google API will use this 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/auth/callback")]
        public async Task<IActionResult> Callback()
        {
            string code = HttpContext.Request.Query["code"];
            string scope = HttpContext.Request.Query["scope"];

            //get token method
            var token = await _googleCalendarService.GetTokens(code, "", "");
            return Ok(token);
        }

        /// <summary>
        /// Returns calendar Events
        /// </summary>
        /// <param name="calendarEventReqDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/user/calendarevent")]
        public async Task<IActionResult> AddCalendarEvent([FromBody] GoogleCalendarReqDTO calendarEventReqDTO)
        {
            var data = _googleCalendarService.AddToGoogleCalendar(calendarEventReqDTO);
            return Ok(data);
        }
    }
}
