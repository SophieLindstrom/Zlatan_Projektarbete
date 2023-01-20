using MauiAppTEST.ViewModel;

namespace MauiAppTEST.View;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    //async void OnButtonClicked(object sender, EventArgs args)
    //{
    //    Console.WriteLine("Vi klickade");
    //    await Shell.Current.GoToAsync(nameof(ProfilePage));
    //}

}