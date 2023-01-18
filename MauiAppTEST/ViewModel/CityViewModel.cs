using CommunityToolkit.Mvvm.Input;
using MauiAppTEST.TestData;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTEST.ViewModel
{
    public partial class CityViewModel : BaseViewModel
    {
        CityServices cityService;
        public ObservableCollection<City> Cities { get; } = new();

        public CityViewModel()
        {
            //Title = "Cities";
            //this.cityService = cityService;
        }

        //protected override void OnNavigatedTo(NavigatedToEventArgs args)
        //{
        //    base.OnNavigatedTo(args);
        //}

        [RelayCommand]
        async Task GetCityAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var cities = await cityService.GetCities();

                if (cities.Count != 0)
                    cities.Clear();

                foreach (var city in cities)
                    Cities.Add(city);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!", $"unable to get monkeys: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
