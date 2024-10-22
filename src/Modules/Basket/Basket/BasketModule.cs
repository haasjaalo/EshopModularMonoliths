﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket
    {
    public static class BasketModule
        {
        public static IServiceCollection AddBasketModule(this IServiceCollection services,
            IConfiguration configuration)
            {

            return services;

            }
        public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
            {
            // Configure the HTTP request pipeline.

            // 1. Use Api Endpoint services

            // 2. Use Application Use Case services

            // 3. Use Data - Infrastructure services  
            //app.UseMigration<CatalogDbContext>();

            return app;
            }
        }
    }