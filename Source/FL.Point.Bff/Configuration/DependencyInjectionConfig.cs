using FL.Point.Bff.Services;
using FL.Point.Bff.Services.Interface;

namespace FL.Point.Bff.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddHttpClient<IEletronicPointService, EletronicPointService>();

            return services;
        }
    }
}
