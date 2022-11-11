﻿namespace rt_restaurant_tracker;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));

        Routing.RegisterRoute(nameof(NewMealPage), typeof(NewMealPage));
        Routing.RegisterRoute(nameof(RestaurantDetailsPage), typeof(RestaurantDetailsPage));
    }
}

