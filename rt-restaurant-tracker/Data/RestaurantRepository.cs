using System;
using SQLite;
using rt_restaurant_tracker.Models;

namespace rt_restaurant_tracker.Data
{
    public class RestaurantRepository
    {
        string _dbPath;
        private SQLiteConnection conn;

        public RestaurantRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<RestaurantInfo>();
        }

        public List<RestaurantInfo> GetAllRestaurants()
        {
            Init();
            return conn.Table<RestaurantInfo>().ToList();
        }

        public RestaurantInfo GetRestaurant(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            return conn.Get<RestaurantInfo>(id);

        }

        public RestaurantInfo GetRestaurantByName(string rName)
        {
            List<RestaurantInfo> list = GetAllRestaurants();
            for (int i = 0; i <= list.Count; i++)
            {
                if (list[i].RestaurantName == rName)
                {
                    return list[i];
                }
            }
            return null;
        }

        public RestaurantInfo GetRestaurantById(int rId)
        {
            List<RestaurantInfo> list = GetAllRestaurants();
            for (int i = 0; i <= list.Count; i++)
            {
                if (list[i].RestaurantId == rId)
                {
                    return list[i];
                }
            }
            return null;
        }

        public void Add(RestaurantInfo restaurant)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(restaurant);
        }

        public void Delete(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(new { RestaurantId = id });
        }
    }
}

