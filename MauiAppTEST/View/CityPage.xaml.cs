using MauiAppTEST.TestData;
using MauiAppTEST.ViewModel;

namespace MauiAppTEST.View;

public partial class CityPage : ContentPage
{
    CityViewModel cityViewModel;
    public CityPage(CityViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}