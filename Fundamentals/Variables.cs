using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class Variables
    {
       public static void Demo()
        {
            string firstName = string.Empty;
            string filePath = string.Empty;
            int age;
            double average;
            decimal bankAccountBalance;
            bool isComplete;


            // variables can store null values 
            int? age_ = null;
            double? bettingAverage = null;
            string? firstJob = null;


            // Initialisation
            firstName = "Dennis";
            age = 15_000;
            average = 4.5;
            bankAccountBalance = 170.59M;
            isComplete = false;

            //Declaration & Initialisation
            string fullName = "Dennis Appiah";
            int scores = 50;
            double average_ = (4.5 + 2) / 5;
            filePath = "C:\\Temp\\Demo";
            //filePath = @"C:\Temp\Demo";


            Console.WriteLine(age);
            Console.WriteLine(average);
            Console.WriteLine(bankAccountBalance);
            Console.WriteLine(isComplete);
            Console.WriteLine(fullName);
            Console.WriteLine(filePath);
            Console.WriteLine(scores);
            Console.WriteLine(average_);


            // Working with the DateTime variable (mm/dd/yy)
            DateTime today = DateTime.UtcNow;
            var hour = DateTime.UtcNow.Hour;
            //DateTime birthday = DateTime.Parse("6/15/1998");
            //DateTime birthday = DateTime.ParseExact("6/6/1998", "d/M/yyy", CultureInfo.InvariantCulture);
            //Console.WriteLine($"Today's date is: {today.Date}");


            Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zz"));


            DateOnly birthday = DateOnly.Parse("6/11/1998");

            Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));


            TimeOnly opensAt = TimeOnly.Parse("8:00 AM");
            TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

            Console.WriteLine(opensAt);
            Console.WriteLine(rightNow);


            string? value;
            DateOnly ageNow;
            DateOnly ageInTwentyYears;
            DateOnly ageFiveYearsAgo;

            Console.WriteLine("What is your date of birth (MM/dd/yyyy)?: ");

            value = Console.ReadLine();

            if (DateOnly.TryParse(value, out ageNow))
            {
                ageInTwentyYears = ageNow.AddYears(20);
                ageFiveYearsAgo = ageNow.AddYears(-5);

                Console.WriteLine("---------------------");
                Console.WriteLine($"Your date of birth is: {ageNow}");
                Console.WriteLine($"Age in Twenty Years is {ageInTwentyYears}");
                Console.WriteLine($"Age Five years ago is {ageFiveYearsAgo}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for your age.");
            }

        }
    }
}
