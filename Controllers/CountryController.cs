using NatterbaseProject.Models;
using NatterbaseProject.ViewModels;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace NatterbaseProject.Controllers
{
    [Authorize]
    public class CountryController : ApiController
    {
        // GET /api/country
        public async Task<IHttpActionResult> Get()
        {

            using (var db = new CountryRepository())
            {
                var countries = await db.GetAllCountries();

                return Ok(countries);
            }
        }

        // PUT /api/country/:id
        public async Task<IHttpActionResult> Put(int id, [FromBody] CountryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (var db = new CountryRepository())
            {
                var country = await db.FindCountry(id);

                country.Continent = model.Continent;
                country.Name = model.Name;
                country.DateModified = DateTime.Now;

                await db.EditCountry(country);
            }

            return Ok();
        }

        // POST /api/country
        public async Task<IHttpActionResult> Post(CountryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (var db = new CountryRepository())
            {
                var country = new Country
                {
                    Continent = model.Continent,
                    Name = model.Name,
                    DateModified = DateTime.Now
                };

                await db.CreateCountry(country);
            }

            return Ok();
        }

        // DELETE /api/country
        public async Task<IHttpActionResult> Delete(int id)
        {
            using (var db = new CountryRepository())
            {
                await db.DeleteCountry(id);
            }

            return Ok();
        }
    }
}
