using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.GenericsEvents
{
    public static class GenericDemo
    {
        public static string FizzBuzz<T, U>(T item)
        {
            var itemLength = item.ToString().Length;

            string output = "";

            if (itemLength % 3 == 0 && itemLength %5 == 0)
            {
                output += "FizzBuzz";

            } 
            else if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }
            else if(itemLength % 5 == 0)
            {
                output += "Buzz";
            }


            return output;
        }
    }
}
