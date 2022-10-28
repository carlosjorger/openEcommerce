using Application.Common.Interfaces;
using Application.TodoProduct.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class Configuration
    {
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<ProductBusiness>();
        }
    }
}
