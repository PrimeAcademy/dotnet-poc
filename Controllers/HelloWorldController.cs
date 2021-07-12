using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

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
        PeopleList peopleList = new PeopleList();
        // this attribute says map get requests to this function
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return peopleList.People;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            // Console.WriteLine(person.ToString());
            peopleList.Add(person);
            return CreatedAtAction(nameof(Get), person);
        }

    }



}