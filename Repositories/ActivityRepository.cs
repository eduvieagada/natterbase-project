using NatterbaseProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NatterbaseProject.Repositories
{
    public class ActivityRepository : IDisposable
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

        public async Task<List<Activity>> GetActivities(string name)
        {
            var activities = await _db.Activities.Where(x => x.Name == name).ToListAsync();
            return activities;
        }

        public void CreateActivity(Activity activity)
        {
            _db.Activities.Add(activity);
            _db.SaveChanges();
        }
    }
}