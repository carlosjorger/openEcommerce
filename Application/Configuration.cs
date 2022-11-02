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
using FluentValidation;
using FluentValidation.AspNetCore;
using Application.Products.Commands.EditProduct;
using Microsoft.Extensions.Options;
using Application.Common.Behaviour;

namespace Application
{
    public static class Configuration
    {
        public static void AddMediatRConfiguration(this IServiceCollection services){
            
            
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        }
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<ProductBusiness>();
        }
    }
}
