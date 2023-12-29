using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class Conditions
    {
        public static void Demo()
        {

            Console.WriteLine("What is your first name?: ");
            string? firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?: ");
            string? lastName = Console.ReadLine();

            if (firstName.ToLower() == "dennis" && lastName.ToLower() == "appiah")
            {
                Console.WriteLine($"Hello {firstName} {lastName}");
            }
            else if (firstName.ToLower() == "dennis")
            {
                Console.WriteLine($"Hello {firstName}");
            }
            else
            {
                Console.WriteLine("You are not real person");
            }

            switch (firstName.ToLower())
            {
                case "tim":
                case "dennis":
                    Console.WriteLine("Hello Tim");
                    break;
                case "appiah" or "app":
                    Console.WriteLine("Hello Appiah");
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
        }
    }
}
