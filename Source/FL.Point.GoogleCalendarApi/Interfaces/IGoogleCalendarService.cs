using FL.Point.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Point.GoogleCalendarApi.Interfaces
{
    public interface IGoogleCalendarService
    {
        string GetAuthCode(string clientID, string unreservedChars);

        Task<GoogleTokenResponse> GetTokens(string code, string clientID, string clientSecret);
        string AddToGoogleCalendar(GoogleCalendarReqDTO googleCalendarReqDTO, string clientID, string clientSecret);
    }
}
