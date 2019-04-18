using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : Controller
    {
        private IPersonService _personService;
        private IPersonService personService;

        public PersonsController(PersonService service)
        {
            _personService = personService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var models = _personService.GetAll();

            return Ok;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // var model = _personService.Get(id);

            return NewMethod();
        }

        private IActionResult NewMethod() => Ok;

        private new IActionResult Ok
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Person model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            object person = NewMethod1(model);

            return NewMethod1(person);
        }

       /* private object NewMethod2(Person model)
        {
            return _personService.Add(model);
        }*/

        private IActionResult NewMethod1(object person)
        {
            return NewMethod1(person);
        }

        /*   private IActionResult NewMethod2(object person)
           {
               return CreatedAtAction("Get", routeValues: new { id = person.Id }, value: person);
           }*/

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Person model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _personService.Update(id, model);

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return NoContent();
        }
        public class Person
        {
            public int Id { get; set; }
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            public string Title { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            [Required]
            [Phone]
            public string Phone { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }
    }
}