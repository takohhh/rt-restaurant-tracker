using System;
using SQLite;

namespace rt_restaurant_tracker.Models
{
    public class RestaurantInfo
    {
        public RestaurantInfo()
        {
            //needed parameterless constructor
        }

        public RestaurantInfo(string rName, string rDesc)
        {
            this.RestaurantName = rName;
            this.RestaurantDesc = rDesc;
            this.FlavourRating = 0;
            this.PriceRating = 0;
            this.OverallRating = 0;
        }

        [PrimaryKey, AutoIncrement, Column("RestaurantId")]
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantDesc { get; set; }
        public int FlavourRating { get; set; }
        public int PriceRating { get; set; }
        public int OverallRating { get; set; }
    }
}

