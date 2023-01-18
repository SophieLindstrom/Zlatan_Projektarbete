using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppTEST.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTEST.ViewModel
{
    //ObservableObject
    public partial class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {

        }

        [RelayCommand]
        Task Navigation() => Shell.Current.GoToAsync(nameof(CityPage));'

        [RelayCommand]
        Task NavigateToDetailPage() => Shell.Current.GoToAsync(nameof(DetailPage));

        //[ObservableProperty]
        //ObservableCollection<string> items;

        //[ObservableProperty]
        //string text;

        //[RelayCommand]
        //async Task Tap(string s)
        //{
        //    await Shell.Current.GoToAsync(nameof(CityPage));
        //}

        //void NavigationPages()
        //{
        //    Items = new ObservableCollection<string>();

        //    Items.Add("MainPage");
        //}
    }
}
