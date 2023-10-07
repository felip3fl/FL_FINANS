using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using System.Xml.Xsl;

namespace FL.Point.GoogleCalendarApi
{
    public class GoogleCalendarApiClass
    {
        const string ApiKey = "";
        const string CalendarId = "";

        public async void ListAll()
        {

            var service = new CalendarService(new BaseClientService.Initializer()
            {
                ApiKey = ApiKey,
                ApplicationName = "Teste"
            });

            var request = service.Events.List(CalendarId);
            request.Fields = "items(summary, start, end)";
            var responde = await request.ExecuteAsync();

            foreach(var item in responde.Items)
            {
                Console.WriteLine($"Aqui: {item.Summary}");
            }
        }
    }
}