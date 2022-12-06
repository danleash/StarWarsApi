using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarWarsApi.Shared.BaseModel;

namespace StarWarsApi.Shared.PlanetModels
{
    public class StarWarsPlanets
    {
        [JsonProperty("results")]
        public List<StarWarsPlanet> Planets { get; set; }
    }
    public class StarWarsPlanet 
    {

        [JsonProperty("climate")]
        public string Climate { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("diameter")]
        
        public string Diameter { get; set; }

        [JsonProperty("edited")]
        public DateTimeOffset Edited { get; set; }

        [JsonProperty("films")]
        public Uri[] Films { get; set; }

        [JsonProperty("gravity")]
        
        public string Gravity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orbital_period")]
        
        public string OrbitalPeriod { get; set; }

        [JsonProperty("population")]
        
        public string Population { get; set; }

        [JsonProperty("residents")]
        public Uri[] Residents { get; set; }

        [JsonProperty("rotation_period")]
        
        public string RotationPeriod { get; set; }

        [JsonProperty("surface_water")]
        
        public string SurfaceWater { get; set; }

        [JsonProperty("terrain")]
        public string Terrain { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

    }
}
