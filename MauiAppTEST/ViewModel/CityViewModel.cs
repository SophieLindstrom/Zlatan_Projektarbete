using MauiAppTEST.TestData;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Mac;

namespace MauiAppTEST.ViewModel
{
    internal class CityViewModel : BaseViewModel
    {
        CityServices cityService;
        public ObservableCollection<City> Cities { get; } = new();

        public CityViewModel(CityServices cityServices)
        {
            this.cityService = cityServices;
        }
    }
}
