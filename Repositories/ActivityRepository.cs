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

        public async Task<List<Activity>> GetActivities()
        {
            var activities = await _db.Activities.ToListAsync();
            return activities;
        }
    }
}