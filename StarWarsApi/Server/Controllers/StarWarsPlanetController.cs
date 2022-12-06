using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StarWarsApi.Shared.PlanetModels;
using StarWarsApi.Shared.ResultModels;

namespace StarWarsApi.Server.Controllers
{
    [Route("api/")]
    [ApiController]
    [AllowAnonymous]
    public class StarWarsPlanetController : Controller
    {
        [HttpGet("GetPlanets")]

        public async Task<IActionResult> GetPlanets()
        {
            //Call the Star Wars API
            try
            {
                var _httpClient = new HttpClient();
                //Set up client
                _httpClient.BaseAddress = new Uri("https://swapi.dev/api/");
                var route = "planets";
                var response = await _httpClient.GetAsync(route);
                //Verify successful completion (200) ok 
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error retrieving the Star Wars Planets. Error: {response.ReasonPhrase}");
                }
                var serializedPlanets = await response.Content.ReadAsStringAsync();
                //Deserialize into list of planets
                var planets = JsonConvert.DeserializeObject<StarWarsPlanets>(serializedPlanets)?.Planets;
                if (!planets.Any()) throw new Exception($"There were no planets returned from Star Wars Api");
                //Send back the response to the client
                var controllerResponse = new StarWarsPlanetsResponseModel { Message = "Successfully retrieved the planets from Star Wars Api", Success = true, Planets = planets };
                return Ok(controllerResponse);
            }
            catch (Exception ex)
            {
                return
                    new BadRequestObjectResult(new StarWarsPlanetsResponseModel { Planets = null, Success = false, Message = $"{ex.Message}" });
            }
        }
    }
}
