using FL.Point.Model;

namespace FL.Point.GoogleCalendarApi.Interfaces
{
    public interface IGoogleCalendarService
    {
        string GetAuthCode(string clientID, string unreservedChars);
        Task<GoogleTokenResponse> GetTokens(string code, string clientID, string clientSecret);
        Task<GoogleTokenResponse> GetAndSaveTokens(string code, string clientID, string clientSecret);
        string AddToGoogleCalendar(GoogleCalendarReqDTO googleCalendarReqDTO);
    }
}
