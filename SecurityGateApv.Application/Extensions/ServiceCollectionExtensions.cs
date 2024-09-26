using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SecurityGateApv.Application.Common;
using SecurityGateApv.Application.Services;
using SecurityGateApv.Application.Services.Interface;
using SecurityGateApv.Domain.Interfaces.Repositories;
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
            services.AddScoped<IVisitService, VisitService>();
            //services.AddScoped<IVisitDetai, VisitService>();
            services.AddScoped<IVisitorSessionService, VisitorSessionService>();
            services.AddScoped<IVisitService, VisitService>();
            services.AddScoped<IQRCodeService, QRCodeService>();
            services.AddScoped<IProcessService, ProcessSerivce>();
            services.AddScoped<IGateService, GateService>();
            services.AddFluentValidation();
            services.AddValidatorsFromAssemblyContaining<IAssemblyMarker>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
