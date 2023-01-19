﻿using MauiAppTEST.View;
using MauiAppTEST.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiAppTEST;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Logging.AddDebug();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<CityViewModel>();
        builder.Services.AddSingleton<DetailViewModel>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<SignUpViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<CityPage>();
        builder.Services.AddSingleton<DetailPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<SignUpPage>();

        return builder.Build();
	}
}
