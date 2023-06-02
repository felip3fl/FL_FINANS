using FL.Point.Data.Inferfaces;
using FL.Point.Data.Repositories;

namespace FL.Point.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            #region INFRA
            services.AddScoped<IFinancialTransactionRepository, FinancialTransactionRepository>();
            services.AddScoped<IEletronicPointRepository, EletronicPointRepository>();
            #endregion

            return services;
        }
    }
}
