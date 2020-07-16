using System;
using System.Net.Http;
using BlazorApp1.Client.Servicio;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp1.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(new HttpClient { BaseAddress = new Uri("https://localhost:44354/") });
            services.AddScoped<IWeatherService, WeatherService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
