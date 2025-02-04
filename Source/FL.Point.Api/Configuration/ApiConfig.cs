﻿using FL.Point.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace FL.Point.Api.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {

            services.AddCors(
                options =>
                {
                    options.AddPolicy( "AllowOrigin", builder =>
                    builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin()
                    );

                }
            );

            services.AddEndpointsApiExplorer();
            services.AddControllers();

            services.AddDbContext<DataBaseContext>();

            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {

            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            return app; 
        }
    }
}

