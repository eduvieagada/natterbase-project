using NatterbaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatterbaseProject.Repositories
{
    interface ICountryRepository : IDisposable
    {
        Task CreateCountry(Country country);
        Task EditCountry(Country country);
        Task DeleteCountry(int id);
        Task<List<Country>> GetAllCountries();
        Task<Country> FindCountry(int id);
    }
}
