using rt_restaurant_tracker.Models;
using rt_restaurant_tracker.ViewModels;
using System.Collections.ObjectModel;

namespace rt_restaurant_tracker;

public partial class NewMealPage : ContentPage
{
    public NewMealPage()
    {
        InitializeComponent();

        this.BindingContext = App.mainViewModel;
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        //RestaurantInfo restaurant = rPicker.SelectedItem as RestaurantInfo;
        //TitleLabel.Text = restaurant.RestaurantId.ToString();
        //DisplayMeals = new ObservableCollection<MealInfo>(App.MealRepository.GetMealsFromRestaurantId(restaurant.RestaurantId));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        mPicker.SetBinding(Picker.ItemsSourceProperty, "DisplayMeals");
        mPicker.ItemDisplayBinding = new Binding("MealName");
    }

    private void NewReviewButton_Clicked(object sender, EventArgs e)
    {
        MealInfo meal = mPicker.SelectedItem as MealInfo;
        int userId = App.mainViewModel.LoggedInUser;
        App.ReviewRepository.Add(
            new ReviewInfo(meal.MealId, userId, int.Parse(FlavourEntry.Text), int.Parse(PriceEntry.Text))
            );
    }
}
