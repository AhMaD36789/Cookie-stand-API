using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Salmon_Cookie_Application_API.Data;
using Salmon_Cookie_Application_API.Models.Services;

namespace Salmon_Cookie_Application_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            string connString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<CookieDBContext>(options => options.UseSqlServer(connString));

            builder.Services.AddTransient<ICookieStandService, CookieStandService>();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Salmon Cookie API", Version = "v1" });
            });

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Salmon Cookie API");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.MapGet("/", () => "Hello World!");
            app.MapControllers();
            app.Run();
        }
    }
}