
using dotnet_common.Interfaces;
using dotnet_demo.Services;

namespace dotnet_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IWeatherService, WeatherService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(cors => cors
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .SetIsOriginAllowedToAllowWildcardSubdomains().SetIsOriginAllowed(_ => true));

            app.UseAuthorization();



            app.MapControllers();

            app.Run();
        }
    }
}
