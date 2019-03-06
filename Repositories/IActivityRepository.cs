using NatterbaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatterbaseProject.Repositories
{
    interface IActivityRepository : IDisposable
    {
        Task<List<Activity>> GetActivities(string name, int index, int size);
        void CreateActivity(Activity activity);
    }
}
