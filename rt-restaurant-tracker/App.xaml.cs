using rt_restaurant_tracker.Data;

namespace rt_restaurant_tracker;

public partial class App : Application
{
    public static UserRepository UserRepository { get; private set; }
    public static ReviewRepository ReviewRepository { get; private set; }
    public static RestaurantRepository RestaurantRepository { get; private set; }
    public static MealRepository MealRepository { get; private set; }

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

    }
}