using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using rt_restaurant_tracker;
using rt_restaurant_tracker.Models;

namespace rt_restaurant_tracker.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {
            AllRestaurants = new ObservableCollection<RestaurantInfo>();

            List<RestaurantInfo> list = App.RestaurantRepository.GetAllRestaurants();
            Restaurants = new ObservableCollection<string>();
            for (int i=0; i!=list.Count; i++)
            {
                Restaurants.Add(list[i].RestaurantName);
                AllRestaurants.Add(list[i]);
            }
            
        }

        [ObservableProperty]
        ObservableCollection<RestaurantInfo> allRestaurants;

        [ObservableProperty]
        ObservableCollection<ReviewInfo> allReviews;

        [ObservableProperty]
        ObservableCollection<string> restaurants;

        [ObservableProperty]
        ObservableCollection<string> meals;
    }
}

