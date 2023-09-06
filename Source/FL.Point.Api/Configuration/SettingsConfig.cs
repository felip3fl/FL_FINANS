using FL.Point.Api.Settings;
using FL.Point.Data.Data;
using Microsoft.Extensions.Hosting;

namespace FL.Point.Api.Configuration
{
    public static class SettingsConfig
    {
        public static GoogleAuthenticatorSettings googleAuthenticator;

        public static void SettingConfiguration(this WebApplication app)
        {
            googleAuthenticator = app.Configuration.GetSection("Settings").Get<GoogleAuthenticatorSettings>();
        }
    }
}
