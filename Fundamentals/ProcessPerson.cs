using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class ProcessPerson
    {

        public static void GreetPerson(PersonModel person)
        {
            person.HasBeenGreeted = true;
        }
    }
}
