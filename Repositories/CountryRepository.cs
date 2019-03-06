using NatterbaseProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NatterbaseProject
{
    public class CountryRepository : IDisposable
    {
        private CountryDb _db;
        public CountryRepository()
        {
            _db = new CountryDb();
        }

        public async Task CreateCountry(Country country)
        {
            _db.Countries.Add(country);
            await _db.SaveChangesAsync();
        }

        public async Task EditCountry(Country country)
        {
            _db.Countries.Add(country);
            _db.Entry(country).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public async Task DeleteCountry(int id)
        {
            var country = _db.Countries.Find(id);
            _db.Entry(country).State = EntityState.Deleted;
            await _db.SaveChangesAsync();
        }

        public async Task<List<Country>> GetAllCountries()
        {
            var countries = await _db.Countries.ToListAsync();
            return countries;
        }
        public async Task<Country> FindCountry(int id)
        {
            var country = await _db.Countries.FindAsync(id);
            return country;
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}