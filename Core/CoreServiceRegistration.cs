using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MediatR;
using CQRSDemoAPI.Core.Pipeline;
using CQRSDemoAPI.Core.Filter;
using FluentValidation.AspNetCore;

namespace Core
{
    public static class CoreServiceRegistration
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddMvc(
                opt =>
                {
                    opt.Filters.Add(typeof(ExceptionFilter));
                })
                .AddFluentValidation(cfg => { cfg.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()); });

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingInterceptor<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
