using System;
using SQLite;

namespace rt_restaurant_tracker.Models
{
    public class ReviewInfo
    {
        public ReviewInfo()
        {
            //needed parameterless constructor
        }

        public ReviewInfo(int mealId, int userId, string resName, string mealName,  int flavour, int price)
        {
            this.MealId = mealId;
            this.RestaurantName = resName;
            this.MealName = mealName;
            this.UserId = userId;
            this.FlavourRating = flavour;
            this.PriceRating = price;
        }

        [PrimaryKey, AutoIncrement, Column("ReviewId")]
        public int ReviewId { get; set; }
        public int MealId { get; set; }
        public int UserId { get; set; }
        public string RestaurantName { get; set; }
        public string MealName { get; set; }
        public int FlavourRating { get; set; }
        public int PriceRating { get; set; }
    }
}

