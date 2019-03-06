using NatterbaseProject.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NatterbaseProject.Tests
{
    [TestFixture]
    public class CountryTests
    {
        [Test]
        public async Task CountryRepository_Should_Return_Countries()
        {
            List<Country> countries;
            using (var repo = new CountryRepository())
            {
                countries = await repo.GetAllCountries(0, 1);
            }

            Assert.IsNotEmpty(countries);
        }


        [Test]
        public void CountryRepository_Should_SaveCountry()
        {
            using (var repo = new CountryRepository())
            {
                Assert.DoesNotThrowAsync(async () =>  await repo.CreateCountry(new Country
                {
                    Name = "Aruba",
                    Continent = "Asia"
                }));
            }
        }


    }
}