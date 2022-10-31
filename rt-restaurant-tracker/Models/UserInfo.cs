using System;
using SQLite;
namespace rt_restaurant_tracker.Models
{
    public class UserInfo
    {
        [PrimaryKey, AutoIncrement, Column("UserId")]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

