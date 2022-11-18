using CommunityToolkit.Mvvm.ComponentModel;
using rt_restaurant_tracker.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace rt_restaurant_tracker.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<RestaurantInfo> Restaurants { get; private set; }
        public ObservableCollection<ReviewInfo> Reviews { get; private set; }
        public ObservableCollection<MealInfo> DisplayMeals { get; private set; }
        public RestaurantInfo DisplayRestaurant { get; private set; }

        public MainViewModel()
        {
            Text = "Hello world";

            List<RestaurantInfo> list = App.RestaurantRepository.GetAllRestaurants();
            Restaurants = new ObservableCollection<RestaurantInfo>(list);

            List<ReviewInfo> reviewList = App.ReviewRepository.GetAllReviews();
            Reviews = new ObservableCollection<ReviewInfo>(reviewList);

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

        public ICommand ChooseRestaurantCommand
        {
            get
            {
                return new Command<object>((x) => CRCommand(x));
            }
        }

        public void CRCommand(object x)
        {
            if (x != null)
            {
                RestaurantInfo restaurant = x as RestaurantInfo;
                Text = restaurant.RestaurantId.ToString();
                DisplayMeals = new ObservableCollection<MealInfo>( App.MealRepository.GetMealsFromRestaurantId(restaurant.RestaurantId) );
            }
            
        }

        [ObservableProperty]
        RestaurantInfo myRestaurant;

        [ObservableProperty]
        string text;

        //user id of currently logged in user (to record which user made which review)
        [ObservableProperty]
        int loggedInUser;
    }
}