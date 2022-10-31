using rt_restaurant_tracker.Models;
using rt_restaurant_tracker.ViewModels;

namespace rt_restaurant_tracker;

public partial class NewMealPage : ContentPage
{
	public NewMealPage()
	{
		InitializeComponent();

		this.BindingContext = this;
    }
}
