using FL.Point.Api.Configuration;
using FL.Point.Api.Settings;
using FL.Point.GoogleCalendarApi.Interfaces;
using FL.Point.Model;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FL.Point.Api.Controllers.V1
{
    public class AuthorizationController : Controller
    {

        private IGoogleCalendarService _googleCalendarService;
        private GoogleAuthenticatorSettings _authenticatorSettings = SettingsConfig.googleAuthenticator;

        private static GoogleTokenResponse token;

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
            return Redirect(_googleCalendarService.GetAuthCode(_authenticatorSettings.ClientID, _authenticatorSettings.UnreservedChars));
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
            token = await _googleCalendarService.GetAndSaveTokens(code, _authenticatorSettings.ClientID, _authenticatorSettings.ClientSecret);
            return Ok(token);
        }

        //[HttpPost]
        //[Route("/user/calendarevent")]
        //public async Task<IActionResult> AddCalendarEvent([FromBody] GoogleCalendarReqDTO calendarEventReqDTO)
        //{
        //    calendarEventReqDTO.refreshToken = token.refresh_token;
        //    var data = _googleCalendarService.AddToGoogleCalendar(calendarEventReqDTO, _authenticatorSettings.ClientID, _authenticatorSettings.ClientSecret);
        //    return Ok(data);
        //}
    }
}
