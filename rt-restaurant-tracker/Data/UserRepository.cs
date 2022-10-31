using System;
using SQLite;
using rt_restaurant_tracker.Models;

namespace rt_restaurant_tracker.Data
{
    public class UserRepository
    {
        string _dbPath;
        private SQLiteConnection conn;

        public UserRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<UserInfo>();
        }

        public List<UserInfo> GetAllUsers()
        {
            Init();
            return conn.Table<UserInfo>().ToList();
        }

        public UserInfo GetUser(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            return conn.Get<UserInfo>(id);
            
        }

        public UserInfo GetUserByUsername(string username)
        {
            List<UserInfo> list = GetAllUsers();
            for (int i = 0; i <= list.Count; i++)
            {
                if (list[i].UserName == username)
                {
                    return list[i];
                }
            }
            return null;
        }

        public void Add(UserInfo user)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(user);
        }

        public void Delete(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(new { UserId = id });
        }
    }
}

