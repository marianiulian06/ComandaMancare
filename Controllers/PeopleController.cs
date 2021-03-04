using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Umbraco.Web.WebApi;
using comandamancare.Models;


namespace comandamancare.Controllers
{
    public class PeopleController : UmbracoApiController //ApiController 
    {
        List<Individual> people = new List<Individual>();

        public PeopleController()
        {
            people.Add(new Individual { FirstName = "Tim", LastName = "Corey"});
            people.Add(new Individual { FirstName = "Sue", LastName = "Storm" });
            people.Add(new Individual { FirstName = "Bilbo", LastName = "Baggins" });
        }


        // GET: api/People
        [HttpGet]
        public List<Individual> Get()
        {
            return people;
        }

        // GET: api/People/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
