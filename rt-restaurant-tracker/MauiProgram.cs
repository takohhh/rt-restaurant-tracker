using CommunityToolkit.Maui;
using rt_restaurant_tracker.Data;

namespace rt_restaurant_tracker;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "rt.db");

        builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        builder.Services.AddSingleton(s =>
        ActivatorUtilities.CreateInstance<UserRepository>(s, dbPath));

        builder.Services.AddSingleton(s =>
        ActivatorUtilities.CreateInstance<ReviewRepository>(s, dbPath));

        builder.Services.AddSingleton(s =>
        ActivatorUtilities.CreateInstance<RestaurantRepository>(s, dbPath));

        builder.Services.AddSingleton(s =>
        ActivatorUtilities.CreateInstance<MealRepository>(s, dbPath));

        return builder.Build();
    }
}

