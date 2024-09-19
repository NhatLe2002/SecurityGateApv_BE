﻿using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SecurityGateApv.Application.Common;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddFluentValidation();
            services.AddValidatorsFromAssemblyContaining<IAssemblyMarker>();

            return services;
        }
    }
}
