namespace rt_restaurant_tracker;

public partial class RestaurantDetailsPage : ContentPage
{
    //give page same vm instance as last page
    public RestaurantDetailsPage()
    {
        InitializeComponent();
        this.BindingContext = App.mainViewModel;
    }
}