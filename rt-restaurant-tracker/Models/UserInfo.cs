using System;
using SQLite;
namespace rt_restaurant_tracker.Models
{

    
    public class UserInfo
    {
        public UserInfo()
        {
            //needed parameterless constructor
        }

        public UserInfo(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }


        [PrimaryKey, AutoIncrement, Column("UserId")]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

