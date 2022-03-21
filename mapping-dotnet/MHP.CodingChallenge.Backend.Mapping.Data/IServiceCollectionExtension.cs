using System;
using MHP.CodingChallenge.Backend.Mapping.Data.DB;
using MHP.CodingChallenge.Backend.Mapping.Data.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace MHP.CodingChallenge.Backend.Mapping.Data
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ArticleService));
            services.AddScoped(typeof(ArticleRepository));
            services.AddScoped(typeof(ArticleMapper));
            // Automapper Dependency Injection und Mapping Profile registrieren
            services.AddAutoMapper(c => c.AddProfile<ArticleMapping>());
            return services;
        }

    }
}
