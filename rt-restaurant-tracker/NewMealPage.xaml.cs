namespace rt_restaurant_tracker;

public partial class NewMealPage : ContentPage
{
    public NewMealPage()
    {
        InitializeComponent();

        this.BindingContext = App.mainViewModel;
    }
}
