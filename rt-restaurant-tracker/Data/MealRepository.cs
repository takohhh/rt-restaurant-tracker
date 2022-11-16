using rt_restaurant_tracker.Models;
using System;
using SQLite;

namespace rt_restaurant_tracker.Data
{
    public class MealRepository
    {
        string _dbPath;
        private SQLiteConnection conn;

        public MealRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<MealInfo>();
        }

        public List<MealInfo> GetAllMeals()
        {
            Init();
            return conn.Table<MealInfo>().ToList();
        }

        public MealInfo GetMeal(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            return conn.Get<MealInfo>(id);

        }

        public MealInfo GetMealByName(string mName)
        {
            List<MealInfo> list = GetAllMeals();
            for (int i = 0; i <= list.Count; i++)
            {
                if (list[i].MealName == mName)
                {
                    return list[i];
                }
            }
            return null;

        }

        public List<MealInfo> GetMealsFromRestaurantId(int rId)
        {
            List<MealInfo> list = new List<MealInfo>();
            List<MealInfo> allMeals = GetAllMeals();
            for (int i = 0; i != allMeals.Count; i++)
            {
                if (allMeals[i].RestaurantId == rId)
                {
                    list.Add(allMeals[i]);
                }
            }
            return list;
        }

        public void Add(MealInfo meal)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(meal);
        }

        public void Update(MealInfo newMeal)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Update(newMeal);
        }

        public void Delete(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(new { MealId = id });
        }
    }
}

