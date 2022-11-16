
using System;
using SQLite;

namespace rt_restaurant_tracker.Models
{
    public class MealInfo
    {
        public MealInfo()
        {
            //needed parameterless constructor
        }

        public MealInfo(int rId, string mName, double flavour = 0.0, double price = 0.0)
        {
            this.RestaurantId = rId;
            this.MealName = mName;
            this.FlavourRating = flavour;
            this.PriceRating = price;
        }

        [PrimaryKey, AutoIncrement, Column("MealId")]
        public int MealId { get; set; }
        public int RestaurantId { get; set; }
        public string MealName { get; set; }
        public double FlavourRating { get; set; }
        public double PriceRating { get; set; }
    }
}

