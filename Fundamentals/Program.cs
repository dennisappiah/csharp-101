using Fundamentals;

Methods.WelcomeMessage();

string partyName = Methods.GetPartyName();

//int[] partySizes = Methods.GetPartySizes(5);


//Console.WriteLine($"Party Sizes: {string.Join(',', partySizes)}");
int totalGuests = Methods.GetAllGuests();


Console.WriteLine($"There are {totalGuests} present in the party");




List<double> numbers = [2, 4, 5.5];

double sumOfList = Methods.Total(numbers);

Console.WriteLine(sumOfList);

//tuple

(string firstName, _) = Methods.GetUserName();

//Console.WriteLine(fullName.lastName);
Console.WriteLine(firstName);

Console.WriteLine("--------------------------------------EXCEPTION HANDLING-------------------------");

try
{
    ExceptionHandling.Example();
}
catch (Exception ex)
{
    Console.WriteLine("There was an exception thrown in our app");
    Console.WriteLine(ex.Message);  //"There is an error in the array"
}

try
{
    ExceptionHandling.ComplexMethod("Tim");
    ExceptionHandling.DifferentMethod();
    ExceptionHandling.SimpleMethod();
}
catch (InvalidOperationException ex) // catching most specific exception
{

    Console.WriteLine("You should not be calling these methods");
}
catch (NotImplementedException ex)
{
    Console.WriteLine("You forgot to implement this method");
}
catch (Exception ex) // catching general exception
{
    Console.WriteLine(ex.Message);
}


// ---------------------------------------- CLASS DEMO-----------------------------

// creating instance of the Person class
PersonModel person1 = new PersonModel("Appiah");
person1.FirstName = "Dennis";
person1.SSN = "123-45-6789";

Console.WriteLine(person1.SSN);

PersonModel person2 = new PersonModel("Owusu");
person2.FirstName = "Kofi";

List<PersonModel> persons = new List<PersonModel>();

persons.Add(person1);
persons.Add(person2);

foreach (PersonModel person in persons)
{
    //Console.WriteLine($"{person.FirstName}");
    ProcessPerson.GreetPerson(person);
}



Console.ReadLine();

PersonModel person = new PersonModel("Appiah");






Console.ReadLine();
