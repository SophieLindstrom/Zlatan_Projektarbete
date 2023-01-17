using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Mac;

namespace MauiAppTEST.TestData
{
    internal class CityServices
    {

        public async Task<List<City>> GetCities()
        {
            List<City> cityList = new List<City>()
            {
                new City(){ Name="Paris" },
                new City(){ Name="Venice" },
                new City(){ Name="Rome" },
                new City(){ Name="Bangkok" },
                new City(){ Name="Stockholm" },
                new City(){ Name="New York" },
                new City(){ Name="Tokyo" },
                new City(){ Name="Los Angeles" },
            };

            return cityList;
        }
    }
}
