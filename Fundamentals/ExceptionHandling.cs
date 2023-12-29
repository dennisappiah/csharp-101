using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class ExceptionHandling
    {
        public static void Example()
        {
            List<int> ages = [1, 2, 3, 89, 8];


            for (int i = 0; i <= ages.Count; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Log the error");
                    Console.WriteLine(ex.Message);

                    throw new Exception("There is an error in the array", ex);
                }
            }
        }


        public static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the simple method");
        }

        public static void DifferentMethod()
        {
            throw new NotImplementedException();
        }

        public static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is too tall for this method");
            }
            else
            {
                throw new ArgumentException("This person isn't Tim");
            }
        }
    }
}
