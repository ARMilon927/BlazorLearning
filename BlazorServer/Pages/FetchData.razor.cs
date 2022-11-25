using BlazorServer.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages
{
    public partial class FetchData
    {
       
        public WeatherForecastService ForecastService = new WeatherForecastService();

        private WeatherForecast[]? forecasts;

       

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
