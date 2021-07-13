using System;

namespace DotnetApi
{
    public class Person
    {
        public string name { get; set; }
        private String _id = Guid.NewGuid().ToString();

        public String id
        {
            get
            {
                return this._id;
            }
        }


    }
}