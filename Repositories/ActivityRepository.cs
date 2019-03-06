using NatterbaseProject.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NatterbaseProject.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private CountryDb _db;
        public ActivityRepository()
        {
            _db = new CountryDb();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task<List<Activity>> GetActivities(string name, int index, int size)
        {
            var activities = await Task.Run(() =>_db.Activities.Where(x => x.Name == name).ToPagedList(index, size).ToList());
            return activities;
        }

        public void CreateActivity(Activity activity)
        {
            _db.Activities.Add(activity);
            _db.SaveChanges();
        }
    }
}