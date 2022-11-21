namespace rt_restaurant_tracker;

public partial class MealHistoryPage : ContentPage
{

    public MealHistoryPage()
    {
        InitializeComponent();

        this.BindingContext = App.mainViewModel;
    }

    public void InitReviews()
    {

    }
}
