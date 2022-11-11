using rt_restaurant_tracker.Models;
using rt_restaurant_tracker.ViewModels;

namespace rt_restaurant_tracker;

public partial class RestaurantDetailsPage : ContentPage
{
	//give page same vm instance as last page
	public RestaurantDetailsPage(RestaurantInfo restaurant)
	{
		InitializeComponent();
		this.BindingContext = new MainViewModel();
	}
}