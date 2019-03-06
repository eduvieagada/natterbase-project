using System.Threading.Tasks;
using System.Web.Http;

namespace NatterbaseProject.Controllers
{
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
    }
}
