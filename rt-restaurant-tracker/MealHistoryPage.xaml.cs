using rt_restaurant_tracker.ViewModels;

namespace rt_restaurant_tracker;

public partial class MealHistoryPage : ContentPage
{

    public MealHistoryPage()
    {
        InitializeComponent();

        this.BindingContext = new MainViewModel();
    }
}
