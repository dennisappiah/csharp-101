using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    // BluePrint of the object, more like the plan 
    public class PersonModel
    {
        // properties (prop / propf(tab twice) / states of the object
        public string FirstName { private get; set; }
        public string LastName { get; private set; }

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range");
                }
            }
        }

        public bool HasBeenGreeted { get; set; }

        // public string SSN { get; set; } //social security number 123-45-6789

        private string _ssn;

        public string SSN
        {
            get
            {
                // returning the ssn data in the form ***-**-6789 from '123-45-6789'
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 5);

                return output;
            }
            set
            {
                _ssn = value;
            }
        }


        private string _password;

        public string Password
        {

            set { _password = value; }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }


        // constructor (ctor)
        public PersonModel(string lastName)
        {
            LastName = lastName;
        }


    }
}
