namespace rt_restaurant_tracker;

using rt_restaurant_tracker.Data;
using rt_restaurant_tracker.Models;
using rt_restaurant_tracker.ViewModels;

public partial class RestaurantListPage : ContentPage
{
    MainViewModel vm = new MainViewModel();
    public RestaurantListPage()
	{
		InitializeComponent();

		//get bound 2 
		this.BindingContext = vm;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		//RestaurantInfo x = new RestaurantInfo("restaurant name", "descriptiom");
		//AppShell.Current.GoToAsync($"{nameof(RestaurantDetailsPage)}?", );
        //await Navigation.PushAsync(vm.DisplayRestaurant);
    }
}
