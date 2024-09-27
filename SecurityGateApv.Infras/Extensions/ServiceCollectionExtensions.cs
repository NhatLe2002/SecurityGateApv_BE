using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SecurityGateApv.Domain.Interfaces.AWS;
using SecurityGateApv.Domain.Interfaces.ExtractImage;
using SecurityGateApv.Domain.Interfaces.Jwt;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Infras.AWS;
using SecurityGateApv.Infras.DBContext;
using SecurityGateApv.Infras.Helpers;
using SecurityGateApv.Infras.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString, IConfiguration configuration)
        {
            services.AddDbContext<SecurityGateApvDbContext>(
                options =>
                {
                    options.UseSqlServer(connectionString);
                });

            //DI Core
            services.AddScoped<IUnitOfWork, UnitOfWork<SecurityGateApvDbContext>>();

            //DI Repo
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IVisitRepo, VisitRepo>();
            services.AddScoped<IVisitorSessionRepo, VisitorSessionRepo>();
            services.AddScoped<IQRCardRepo, QRCardRepo>();
            services.AddScoped<IVisitorRepo, VisitorRepo>();
            services.AddScoped<IVisitTypeRepo, VisitTypeRepo>();
            services.AddScoped<IProcessRepo, ProcessRepo>();
            services.AddScoped<IVistProcessRepo, VisitProcessRepo>();
            services.AddScoped<IJwt, JwtHelper>();
            services.AddScoped<IAWSService, AWSServices>();
            services.AddScoped<IExtractQRCode, ExtractQRCode>();

            //JWT
            var key = configuration["Jwt:Key"];
            var issuer = configuration["Jwt:Issuer"];
            var audience = configuration["Jwt:Audience"];

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = issuer,
                        ValidAudience = audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
                    };
                });
            return services;
        }
    }
}
