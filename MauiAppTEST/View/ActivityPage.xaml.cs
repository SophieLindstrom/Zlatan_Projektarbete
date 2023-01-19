using MauiAppTEST.ViewModel;

namespace MauiAppTEST.View;

public partial class ActivityPage : ContentPage
{
	public ActivityPage(ActivityViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}