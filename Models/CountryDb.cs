using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NatterbaseProject.Models
{
    public class CountryDb : DbContext
    {
        public CountryDb() : base("DefaultConnection")
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}