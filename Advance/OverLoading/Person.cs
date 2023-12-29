using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.OverLoading
{
    public class Person
    {
        public string FirstName { private get; set; }
        public string LastName { get; set; }

        // empty constructor
        public Person()
        {
            
        }

        // full constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // semi constructor
        public Person(string firstName)
        {
            FirstName = firstName;
        }
    }
}
