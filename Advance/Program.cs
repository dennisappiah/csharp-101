using Advance.Events.Models;
using Advance.GenericsEvents;
using Advance.Inheritance;
using Advance.Interfaces;
using Advance.MiniProject;
using Advance.OverridingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    public class Program
    {
        static void Main(string[] args)
        {
            // -----------------------INHERITANCE----------------------------------

             List<Phone> phones = new List<Phone>();

            phones.Add(new CellPhone());
            phones.Add(new SmartPhone());
     

            foreach(Phone phone in phones)
            {
              if (phone is CellPhone cell)
                {
                    cell.Carrier = "";
                }
              if (phone is SmartPhone smartPhone)
                {
                    smartPhone.ConnectedToInternet();
                }
            }

            // -----------------------INTERFACE----------------------------------

            /* - Vehicle, Escavator, Book is-a inventory item */

            var vehicle = new Vehicle { DealerFee = 25, ProductName = "Kia Toyota", QuantityInStock = 4 };
            var book = new Book { NumberOfPages = 5, ProductName = "A tale of two cities", QuantityInStock = 4 };
            var escavator = new Escavator { ProductName = "Jubilee Wire Horse Power", QuantityInStock = 4 };


            List<InventoryItem> inventories = new List<InventoryItem>()
            {
                vehicle, book, escavator
            };

           
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            rentables.Add(escavator);
            rentables.Add(vehicle);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.WriteLine("Do you want to continue rent or purchase? ");

            string decision = Console.ReadLine();

            if (decision.ToLower() == "rent")
            {
                foreach(IRentable item in rentables)
                {
                   Console.WriteLine(item.ProductName);

                    item.Rent();
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine(item.ProductName);

                    item.Purchase();
                }

            }

            // ----------------------- GENERICS AND EVENTS ----------------------------------
            GenericDemo.FizzBuzz<string, int>("test");
            GenericDemo.FizzBuzz<Vehicle, Vehicle>(vehicle);


            CollegeClassModel history = new CollegeClassModel("History 101", 4);
            CollegeClassModel math = new CollegeClassModel("Math 101", 4);

            history.EnrolmentFull += History_EnrolmentFull;

            history.SignUpStudent("kofi").PrintToConsole();
            history.SignUpStudent("Owusu").PrintToConsole();
            history.SignUpStudent("Mary").PrintToConsole();
            history.SignUpStudent("Mary").PrintToConsole();

            math.EnrolmentFull += Math_EnrolmentFull;

            math.SignUpStudent("Dennis").PrintToConsole();
            math.SignUpStudent("Appiah").PrintToConsole();
            math.SignUpStudent("Travis").PrintToConsole();

            Console.ReadLine();
        }

        private static void Math_EnrolmentFull(object sender, string e)
        {
            Console.WriteLine($"Enrollment is full for math");
        }

        private static void History_EnrolmentFull(object sender, string e)
        {
            Console.WriteLine($"Enrollment is full for history");
        }
    }
}
