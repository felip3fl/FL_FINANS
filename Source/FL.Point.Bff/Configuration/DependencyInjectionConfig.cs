using FL.Point.Bff.Services;
using FL.Point.Bff.Services.Interface;
using Polly;
using Polly.Extensions.Http;
using Polly.Retry;

namespace FL.Point.Bff.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddHttpClient<IEletronicPointService, EletronicPointService>()
            .AddTransientHttpErrorPolicy(
            p => p.WaitAndRetryAsync(3, _ => TimeSpan.FromMilliseconds(10000)));
            //.AddPolicyHandler(PollyExtensions.EsperarTentar());
            //TODO Polly não está funcionando

            return services;
        }
    }

    public class PollyExtensions
    {
        public static AsyncRetryPolicy<HttpResponseMessage> EsperarTentar()
        {
            var retry = HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(new[]
                {
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(2),
                    TimeSpan.FromSeconds(4),
                }, (outcome, timespan, retryCount, context) =>
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Tentando pela {retryCount} vez!");
                    Console.ForegroundColor = ConsoleColor.White;
                });

            return retry;
        }
    }
}
