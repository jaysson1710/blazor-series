using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BlazorApp1.Client.Model;
using Newtonsoft.Json;

namespace BlazorApp1.Client.Servicio
{
    public interface IWeatherService
    {
        Task<Weather> GetProductAsync(string path);
    }

    public class WeatherService : IWeatherService
    {

        public WeatherService(HttpClient httpClient)
        {
            this.client = httpClient;
            client.BaseAddress = new Uri("http://localhost:44354/WeatherForecast");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private HttpClient client;


        public async Task<Weather> GetProductAsync(string path)
        {
            Weather product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var product1 = await response.Content.ReadAsStringAsync();
                product = JsonConvert.DeserializeObject<Weather>(product1);
            }
            return product;
        }
    }
}
