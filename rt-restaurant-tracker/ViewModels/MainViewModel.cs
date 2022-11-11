using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using rt_restaurant_tracker;
using rt_restaurant_tracker.Models;

namespace rt_restaurant_tracker.ViewModels
{   
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<RestaurantInfo> Restaurants { get; private set; }
        public RestaurantInfo DisplayRestaurant { get; private set; }

        public MainViewModel()
        {
            Text = "Hello world + goodbye";


            List<RestaurantInfo> list = App.RestaurantRepository.GetAllRestaurants();
            Restaurants = new ObservableCollection<RestaurantInfo>(list);
            
        }

        public ICommand CommandWithParam
        {
            get
            {
                return new Command<int>((x) => Paramand(x));
            }
        }

        public void Paramand(int x)
        {
            //Text = "sucCESSSSSSS";
            DisplayRestaurant = App.RestaurantRepository.GetRestaurantById(x);
            Text = DisplayRestaurant.RestaurantName;
            AppShell.Current.GoToAsync(nameof(RestaurantDetailsPage));
        }



        [ObservableProperty]
        RestaurantInfo myRestaurant;

        [ObservableProperty]
        string text;
    }


}

