using System.Collections.Generic;

namespace DotnetApi{
    public class PeopleList {
        public List<Person> People { get; set; }

        public void Add(Person person) {
            this.People.Add(person);
        }
    }
}