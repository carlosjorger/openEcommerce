using Application.Common.Interfaces;
using Application.TodoProduct.Repository;
using Backend.Domain.Models;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class Configuration
    {
        public static void AddMediatRConfiguration(this IServiceCollection services){
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<ProductBusiness>();
        }
    }
}
