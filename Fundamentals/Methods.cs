using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class Methods
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guess Party");
            Console.WriteLine("-----------------------------");
        }


        private static string GetInformationFromConsole(string message)
        {
            Console.Write(message);
            string? output = Console.ReadLine();

            return output;
        }

        public static List<int> GetPartySizes()
        {
            List<int> sizes = new List<int>();

            string partySizeText = "";
            bool IsValidNumber;
            int output;

            do
            {
                partySizeText = GetInformationFromConsole("How many people are in your party?: ");
           
                IsValidNumber = int.TryParse(partySizeText, out output);
            } while (IsValidNumber == false);

            sizes.Add(output);

            return sizes;
        }

     

        public static int GetAllGuests()
        {
            int totalGuests = 0;

            foreach (var size in GetPartySizes())
            {
                totalGuests += size;
            }

            return totalGuests;
        }


        public static double Total(List<double> items)
        {
            double sum = 0;

            foreach (double item in items)
            {
                sum += item;
            }

            return sum;
        }

        //returns a tuple

        public static (string, string) GetUserName()
        {
            string firstName = "Dennis";
            string lastName = "Appiah";

            return (firstName, lastName);
        }
    }
}
