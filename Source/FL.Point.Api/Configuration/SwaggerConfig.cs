using Microsoft.OpenApi.Models;

namespace FL.Point.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "FL Enterprise API",
                    Description = "Esta API faz parte do futuro projeto",
                    Contact = new OpenApiContact() { Name = "Felipe Lima", Email = "felip3.fl@gmail.com" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri(uriString: "https://opensource.org/1icenses/MIT") }
                });

            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            return app;
        }
    }
}
