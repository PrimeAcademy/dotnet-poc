using System.Collections.Generic;
using System;

namespace DotnetApi{
    public class PeopleList {
        public List<Person> People { get; set; }

        public void Add(Person person) {
            Console.WriteLine(person.name);
            People.Add(person);
        }
    }
}