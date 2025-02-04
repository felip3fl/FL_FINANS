﻿using FL.Point.Data.Inferfaces;
using FL.Point.Data.Repositories;

namespace FL.Point.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            #region API
            services.AddScoped<IFinancialTransactionRepository, FinancialTransactionRepository>();
            services.AddScoped<IEletronicPointRepository, EletronicPointRepository>();
            #endregion

            #region Data
            #endregion

            #region Application
            #endregion

            return services;
        }
    }
}
