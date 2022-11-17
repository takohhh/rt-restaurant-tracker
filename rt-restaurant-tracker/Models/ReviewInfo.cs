using System;
using SQLite;

namespace rt_restaurant_tracker.Models
{
    public class ReviewInfo
    {
        [PrimaryKey, AutoIncrement, Column("ReviewId")]
        public int ReviewId { get; set; }
        public int MealId { get; set; }
        public int UserId { get; set; }
        public int FlavourRating { get; set; }
        public int PriceRating { get; set; }
    }
}

