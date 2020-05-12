using Lab1.Models;
using Lab1.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab1.Controllers
{
    public class CountriesController : ApiController
    {
        private TestEntities ctx = new TestEntities();

        // GET: api/Countires
        public IHttpActionResult GetCountries()
        {
            //List<CountryPOCO> countries = ctx.Countries.Select(c =>
            //new CountryPOCO
            //{
            //    Id = c.Id,
            //    Name = c.Name,
            //    Cities = c.Cities.Select(city =>
            //    new CityPOCO
            //    {
            //        Id = city.Id,
            //        Name = city.Name,
            //        Country_Id = city.Country_Id,
            //        Country = city.Country.Name
            //    }).ToList()
            //}).ToList();

            List<Country> countries = ctx.Countries.ToList();

            return Ok(countries);
        }

        // GET: api/Countries/5
        public IHttpActionResult GetCountry(int id)
        {
            Country country = ctx.Countries.Find(id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        // POST: api/Countries
        public IHttpActionResult AddCountry(Country country)
        {
            ctx.Countries.Add(country);
            ctx.SaveChanges();

            return Created("", country);
        }

        // PATCH: api/Countries/5
        public IHttpActionResult EditCountry(int id, Country country)
        {

            if (id != country.Id)
            {
                return BadRequest();
            }

            ctx.Entry(country).State = EntityState.Modified;

            try
            {
                ctx.SaveChanges();

            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Countries/5
        public IHttpActionResult DeleteCountry(int id)
        {
            Country country = ctx.Countries.Find(id);

            if (country == null)
            {
                return NotFound();
            }

            ctx.Countries.Remove(country);
            ctx.SaveChanges();

            return Ok(country);
        }

    }
}
