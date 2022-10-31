namespace rt_restaurant_tracker;

using rt_restaurant_tracker.Data;
using rt_restaurant_tracker.Models;

public partial class RestaurantListPage : ContentPage
{
	public RestaurantListPage()
	{
		InitializeComponent();

		List<RestaurantInfo> list = App.RestaurantRepository.GetAllRestaurants();
		//asdf.Text = list.Count.ToString();
	}
}
