
using System.Text.Json.Serialization;
using AbySalto.Junior.Application;
using AbySalto.Junior.Infrastructure;
using AbySalto.Junior.Infrastructure.Database;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace AbySalto.Junior
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddApplication();
            builder.Services.AddControllers();
            builder.Services.AddOpenApi();
            
            
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFetch", policy =>
                {
                    policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Restaurant", Version = "v1" });
            });

            builder.Services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));//M.G: changed parts of code to fit for postgresql 

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = string.Empty;
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            
            
            // app.UseExceptionHandler(errorApp => // M.G: not sure if this fixes logging
            // {
            //     errorApp.Run(async context =>
            //     {
            //         var error = context.Features.Get<IExceptionHandlerFeature>();
            //         if (error != null)
            //         {
            //             Console.WriteLine($"ERROR: {error.Error.Message}");
            //             Console.WriteLine($"STACK: {error.Error.StackTrace}");
            //         }
            //     });
            // });

            
            app.UseCors("AllowFetch");

            app.MapControllers();
            app.Run();
        }
    }
}
