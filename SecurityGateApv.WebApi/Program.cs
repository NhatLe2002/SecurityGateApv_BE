
using FluentValidation;
using FluentValidation.AspNetCore;
using SecurityGateApv.Application.Common;
using SecurityGateApv.Application.DTOs.Req.Validators;
using SecurityGateApv.Application.Extensions;
using SecurityGateApv.Infras.Extentions;
using System.Reflection;

namespace SecurityGateApv.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetSection("ConnectionStrings").Value;
            // Add services to the container.
            builder.Services.AddInfrastructure(connectionString);
            builder.Services.AddServices();
  

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
