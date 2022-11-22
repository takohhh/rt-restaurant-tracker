using System;
using SQLite;
using rt_restaurant_tracker.Models;

namespace rt_restaurant_tracker.Data
{
    public class ReviewRepository
    {
        string _dbPath;
        private SQLiteConnection conn;

        public ReviewRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<ReviewInfo>();
        }

        public List<ReviewInfo> GetAllReviews()
        {
            Init();
            return conn.Table<ReviewInfo>().ToList();
        }

        public List<ReviewInfo> GetAllReviewsWithUserId(int userId)
        {
            List<ReviewInfo> allReviews = GetAllReviews();
            List<ReviewInfo> list = new List<ReviewInfo>();
            for (int i = 0; i < allReviews.Count; i++)
            {
                if (allReviews[i].UserId == userId)
                {
                    list.Add(allReviews[i]);
                }
            }
            return list;

        }

        public ReviewInfo GetReview(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            return conn.Get<ReviewInfo>(id);

        }

        public void Add(ReviewInfo review)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Insert(review);
        }

        public void Delete(int id)
        {
            conn = new SQLiteConnection(_dbPath);
            conn.Delete(new { ReviewId = id });
        }
    }
}

