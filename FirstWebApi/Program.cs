
using FirstWebApi.Data;
using FirstWebApi.Logger;
using FirstWebApi.Models;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace FirstWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
                    .WriteTo.File("log/student.txt", rollingInterval: RollingInterval.Day).CreateLogger();
            builder.Host.UseSerilog().UseSerilog();
            builder.Services.AddControllers();
            builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Student>());

            builder.Services.AddDbContext<StudentDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }
            );
            

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IMyLogger,MyLogger>();

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
