using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class DataStructures
    {
        public static void Demo()
        {
            // ---------------------ARRAYS-----------------------------------
            // Declaration of Array
            string[] names = new string[5];
            //initialisation
            names[0] = "Appiah";
            names[1] = "Dennis";

            // Declaration and initialisation of Array
            string[] names2 = new string[] { "Corey", "Schafer", "kofi" };

            string data = "Tony, Adwoa, Dennis";
            string[] namelst = data.Split(',');


            // ---------------------LISTS-----------------------------------
            // Declaring of List
            List<string> studentNames = new List<string>();
            studentNames.Add("kofi");
            studentNames.Add("Owusu");

            // Declaration and initialisation of List
            List<string> bigCities = ["Accra", "kumasi", "takoradi"];

            List<string> lastNames = data.Split(",").ToList();

            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames.Count);
            Console.WriteLine(studentNames.Capacity);
            Console.WriteLine(bigCities[0]);
            Console.WriteLine(lastNames[0]);


            // ---------------------DICTIONARIES-----------------------------------
            Dictionary<string, int> studentAges = new Dictionary<string, int>();
            studentAges["kofi"] = 8;
            studentAges["Owusu"] = 10;

            Console.WriteLine($"kofi is {studentAges["kofi"]} years old");


            // ---- FOR LOOPS ----

            /*for (int i = 0; i < bigCities.Count; i++)
            {
                Console.WriteLine(bigCities[i]);
            }*/


            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }


            Console.ReadLine();
        }
    }
}
