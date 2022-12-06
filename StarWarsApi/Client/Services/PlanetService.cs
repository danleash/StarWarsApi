using Newtonsoft.Json;
using StarWarsApi.Shared.PlanetModels;
using StarWarsApi.Shared.ResultModels;
using System.Net.Http;
using System.Net.Http.Json;

namespace StarWarsApi.Client.Services
{
    public class PlanetService
    {
        public async Task<StarWarsPlanetsResponseModel> GetPlanets()
        {
            var _httpClient = new HttpClient();
            var uri = new Uri("https://localhost:7135/api/GetPlanets");
            var response = await _httpClient.GetAsync(uri);
            var serverResponseModel = await response.Content.ReadFromJsonAsync<StarWarsPlanetsResponseModel>();
            return serverResponseModel;
        }
    }
}
