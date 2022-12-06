using StarWarsApi.Shared.BaseModel;
using StarWarsApi.Shared.PlanetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsApi.Shared.ResultModels
{
    public class StarWarsPlanetsResponseModel :  ApiResultBaseModel
    {
        public List<StarWarsPlanet> Planets { get; set; }

    }
}
