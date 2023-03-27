using FL.Data.Inferfaces;
using FL.Data.Repositories;

namespace FL.Finans.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            #region INFRA
            services.AddScoped<IFinancialTransactionRepository, FinancialTransactionRepository>();
            #endregion

            return services;
        }
    }
}
