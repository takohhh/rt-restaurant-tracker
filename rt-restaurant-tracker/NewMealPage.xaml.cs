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
        
        if ((int.TryParse(FlavourEntry.Text, out int flavour) == true) && (int.TryParse(PriceEntry.Text, out int price) == true))
        {
            if ((flavour > 0) && (price > 0) && (flavour < 6) & (price < 6))
            {
                if ((rPicker.SelectedIndex != -1) && (mPicker.SelectedIndex != -1))
                {
                    ErrorMessage.Text = "";
                    Update_Restaurant(flavour, price);
                    Add_Review(flavour, price);
                } else
                {
                    ErrorMessage.Text = rPicker.SelectedIndex.ToString();
                }
                
            }
            else
            {
                ErrorMessage.Text = "Ratings must range from 1 to 5";
            }
        } 
        else
        {

        }
    }

    private void Add_Review(int flavour, int price)
    {
        //add review entry to sql db
        MealInfo meal = mPicker.SelectedItem as MealInfo;
        RestaurantInfo restaurant = App.RestaurantRepository.GetRestaurantById(meal.RestaurantId);
        int userId = App.mainViewModel.LoggedInUser;
        App.ReviewRepository.Add(
            new ReviewInfo(meal.MealId, userId, restaurant.RestaurantName,
            meal.MealName, flavour, price)
            );
    }

    private void Update_Restaurant(int flavour, int price)
    {
        //add review entry to sql db
        MealInfo meal = mPicker.SelectedItem as MealInfo;
        RestaurantInfo restaurant = App.RestaurantRepository.GetRestaurantById(meal.RestaurantId);
        int oldFlavour = restaurant.FlavourRating;
        int oldPrice = restaurant.PriceRating;
        if (oldFlavour == 0)
        {
            restaurant.FlavourRating = flavour;
        } 
        else
        {
            restaurant.FlavourRating = (flavour + oldFlavour) / 2;
        }
        if (oldPrice == 0)
        {
            restaurant.PriceRating = price;
        }
        else
        {
            restaurant.PriceRating = (price + oldPrice) / 2;
        }
        App.RestaurantRepository.Update(restaurant);
    }

}
