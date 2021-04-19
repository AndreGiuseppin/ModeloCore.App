using Microsoft.Extensions.DependencyInjection;
using ModeloCore.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloCore.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ModeloCoreDbContext>();

            return services;
        }
    }
}
