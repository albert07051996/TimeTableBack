
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Rmg.DAL.Database;
using Rmg.DAL.Repositories;
using Rmg.DAL.Repositories.Interfaces;

namespace Rmg.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
{
   options.AddPolicy("AllowAll",
       builder =>
       {
           builder.WithOrigins().AllowAnyMethod().AllowAnyHeader().AllowCredentials();
       });
});


            builder.Services.AddDbContext<_710Context>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<IRmgRepository, RmgRepository>();
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {

            }
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseCors("AllowAll");
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
