using Application.Common.Interfaces;
using Backend.Domain.Models;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class Configuration
    {
        public static void AddDbContexts(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext<Product>, ProductDb>();
        }
    }
}
