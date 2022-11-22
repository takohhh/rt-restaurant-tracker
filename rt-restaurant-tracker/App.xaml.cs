using rt_restaurant_tracker.Data;
using rt_restaurant_tracker.ViewModels;

namespace rt_restaurant_tracker;

public partial class App : Application
{
    public static UserRepository UserRepository { get; private set; }
    public static ReviewRepository ReviewRepository { get; private set; }
    public static RestaurantRepository RestaurantRepository { get; private set; }
    public static MealRepository MealRepository { get; private set; }

    //details to display in restaurantdetailspage
    //public static RestaurantInfo SelectedRestaurant { get; set; }
    public static MainViewModel mainViewModel;

    public static int CurrentUser { get; set; }


    public App(
        UserRepository userRepository,
        ReviewRepository reviewRepository,
        RestaurantRepository restaurantRepository,
        MealRepository mealRepository
        )
    {
        InitializeComponent();

        MainPage = new AppShell();

        UserRepository = userRepository;
        ReviewRepository = reviewRepository;
        RestaurantRepository = restaurantRepository;
        MealRepository = mealRepository;

        //SelectedRestaurant = selectedRestaurant;
        mainViewModel = new MainViewModel();

    }
}