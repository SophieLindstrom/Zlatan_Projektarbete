using MauiAppTEST.TestData;
using MauiAppTEST.ViewModel;

namespace MauiAppTEST.View;

public partial class CityPage : ContentPage
{
    CityViewModel cityViewModel;
    public CityPage()
	{
		InitializeComponent();
		BindingContext = cityViewModel = new CityViewModel();
		//BindingContext = cityViewModel = new ActivityViewModel();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
    //		BindingContext = cityViewModel = new CityViewModel();
}

//G�mma visa, isvisible osv activities och city
//Lesson 02a

//Transient, varje g�ng du �ppnar sidan
//Singleton, varje g�ng du �ppnar applikationen