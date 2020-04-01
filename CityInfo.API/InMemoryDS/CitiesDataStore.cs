using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.InMemoryDS
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; }
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto
                {
                    Id=1,
                    Name="Delhi",
                    Descrition="Capital of India"
                },
                new CityDto
                {
                    Id=2,
                    Name="Bangalore",
                    Descrition="Silicon Valley of India"
                }
            };
        }
    }
}
