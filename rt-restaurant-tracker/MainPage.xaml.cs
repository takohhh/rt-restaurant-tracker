namespace rt_restaurant_tracker;

using rt_restaurant_tracker.Models;
using rt_restaurant_tracker.Data;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void ChangePageBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        AppShell.Current.GoToAsync(nameof(RegisterPage));
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        AppShell.Current.GoToAsync("//HomeMenu");
    }

    void InitMeals()
    {
        List<MealInfo> meals = App.MealRepository.GetAllMeals();
        if (meals.Count == 0)
        {
            //nandos
            MealInfo m1 = new MealInfo(1, "Chicken burger");
            App.MealRepository.Add(m1);
            MealInfo m2 = new MealInfo(1, "Beanie wrap");
            App.MealRepository.Add(m2);
            //caesars
            MealInfo m3 = new MealInfo(2, "Margerhita pizza");
            App.MealRepository.Add(m3);
            MealInfo m4 = new MealInfo(2, "Arrabiatta pasta");
            App.MealRepository.Add(m4);

            //yuzu
            MealInfo m5 = new MealInfo(3, "Korean BBQ Bao Bun");
            App.MealRepository.Add(m5);
            MealInfo m6 = new MealInfo(3, "Katsu Udon Bowl");
            App.MealRepository.Add(m6);
            //waga
            MealInfo m7 = new MealInfo(4, "Chicken ramen");
            App.MealRepository.Add(m7);
            MealInfo m8 = new MealInfo(4, "Beef ramen");
            App.MealRepository.Add(m8);
        }
    }

    void InitRestaurants()
    {
        List<RestaurantInfo> restaurants = App.RestaurantRepository.GetAllRestaurants();
        if (restaurants.Count == 0)
        {
            RestaurantInfo r1 = new RestaurantInfo("Nandos", "free if you steal from the kitchen");
            App.RestaurantRepository.Add(r1);
            RestaurantInfo r2 = new RestaurantInfo("Caesars", "pizza, pasta, vino");
            App.RestaurantRepository.Add(r2);
            RestaurantInfo r3 = new RestaurantInfo("YUZU Street Food", "the best");
            App.RestaurantRepository.Add(r3);
            RestaurantInfo r4 = new RestaurantInfo("Wagamama", "zsds sjdnf asjnsak n dsj knsk cnkdsnk skndknsk dkakns");
            App.RestaurantRepository.Add(r4);
        }
    }
}


