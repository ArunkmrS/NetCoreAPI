using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("api/cities")]
         public JsonResult GetCities()
        {
            return new JsonResult(

                new List<Object>()
                {
                    new {Id=1, Name="Delhi"},
                    new {Id=2, Name="Bangalore"}
                });
        }
    }
}
