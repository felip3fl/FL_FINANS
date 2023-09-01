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
        string GetAuthCode();

        Task<GoogleTokenResponse> GetTokens(string code);
        string AddToGoogleCalendar(GoogleCalendarReqDTO googleCalendarReqDTO);
    }
}
