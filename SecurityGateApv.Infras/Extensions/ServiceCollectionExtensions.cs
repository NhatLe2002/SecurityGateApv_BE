using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Infras.DBContext;
using SecurityGateApv.Infras.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
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

            return services;
        }
    }
}
