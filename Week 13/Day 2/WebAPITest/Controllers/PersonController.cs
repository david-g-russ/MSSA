using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private List<Person> people = new();

        public PersonController()
        {
            people.Add(new Person() { Id = 1, Name = "Deepali", Age = 30, City = "NYC" });
            people.Add(new Person() { Id = 2, Name = "Jason",  Age = 44, City = "MN"});
            people.Add(new Person() { Id = 3, Name = "Bob", Age = 29, City = "DC" });
            people.Add(new Person() { Id = 4, Name = "Jack", Age = 20, City = "LA" });
        }

        [HttpGet()]
        //[Produces("application/xml")]
        public List<Person> GetPeople()
        {
            return this.people;
        }

        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            var person = this.people.Find(x => x.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}