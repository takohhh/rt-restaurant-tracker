using CommunityToolkit.Mvvm.ComponentModel;
using rt_restaurant_tracker.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace rt_restaurant_tracker.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<RestaurantInfo> Restaurants { get; private set; }
        public ObservableCollection<MealInfo> DisplayMeals { get; private set; }
        public RestaurantInfo DisplayRestaurant { get; private set; }

        public MainViewModel()
        {
            Text = "Hello world + goodbye";


            List<RestaurantInfo> list = App.RestaurantRepository.GetAllRestaurants();
            Restaurants = new ObservableCollection<RestaurantInfo>(list);

        }

        public ICommand DisplayRestaurantCommand
        {
            get
            {
                return new Command<int>((x) => DRCommand(x));
            }
        }

        public void DRCommand(int x)
        {
            //Text = "sucCESSSSSSS";
            DisplayRestaurant = App.RestaurantRepository.GetRestaurantById(x);
            DisplayMeals = new ObservableCollection<MealInfo>(App.MealRepository.GetMealsFromRestaurantId(x));
            AppShell.Current.GoToAsync(nameof(RestaurantDetailsPage));
        }



        [ObservableProperty]
        RestaurantInfo myRestaurant;

        [ObservableProperty]
        string text;
    }


}