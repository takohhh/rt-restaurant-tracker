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
        public ObservableCollection<RestaurantInfo> Restaurants { get; private set; }

        public MainViewModel()
        {
            Text = "Hello world + goodbye";

            
            List<RestaurantInfo> list = App.RestaurantRepository.GetAllRestaurants();
            for (int i=0; i!=list.Count; i++)
            {
                Restaurants.Add(list[i]);
            }
            
        }

        [ObservableProperty]
        string text;
    }


}

