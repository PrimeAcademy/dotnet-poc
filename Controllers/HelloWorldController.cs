using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DotnetApi.Controllers
{
    /*  Attributes help describe this class */
    [ApiController]
    //this attribute is our endpoint. 
    // "[controller]" is special, it maps to the name of the class
    // so this controller route is /HelloWorld
    [Route("[controller]")]

    public class HelloWorldController : ControllerBase
    {
        private static List<Person> peopleList = new List<Person>();
        // this attribute says map get requests to this function
        [HttpGet]
        public IEnumerable<Person> Get()
        {   
            return peopleList;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            peopleList.Add(person);
            return CreatedAtAction(nameof(Get), person);
        }

        // URL Param Syntax
        [HttpDelete("{id}")]
        public IActionResult Delete(String id)
        {
            Console.WriteLine(id);
            peopleList.RemoveAll( person => {
                Console.WriteLine(person.id);
                return person.id == id;
            });
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Put(String id, [FromBody] Person person)
        {
            Console.WriteLine(id);

            var changingPerson = peopleList.FirstOrDefault(p => p.id == id);
            if (changingPerson != null) { changingPerson.name = person.name; }
            return Ok();
        }

    }



}