namespace rt_restaurant_tracker;
using rt_restaurant_tracker.Data;
using rt_restaurant_tracker.Models;
public partial class RestaurantListPage : ContentPage
{
    public RestaurantListPage()
    {
        InitializeComponent();

        //get bound 2 
        this.BindingContext = App.mainViewModel;
    }

}
