using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public class ContactPerson
//{
    //public static void ConPetactrson1()
    //{
    //    //string personName = Console.ReadLine();
    //    //Console.WriteLine(personName);

    //    Console.WriteLine("Welcome to my address book program");
    //    Console.WriteLine("*****************************");
    //    Console.WriteLine("Press 1 to Add an entry to the address book");
    //    //Console.WriteLine("Press 2 to Remove any entry in the address book");
    //    //Console.WriteLine("Press 3 to Print the book to the screen");
    //    //Console.WriteLine("Press 4 to Edit a record");
    //    //Console.WriteLine("Press 5 to Search for a record");
    //    Console.ReadLine();


    //    Console.WriteLine("Please Enter your Lastname");
    //    string str2 = "Lastname";
    //    str2 = Console.ReadLine();
    //    string valueString2 = str2;

    //    Console.WriteLine("Please Enter your Firstname");
    //    string str1 = "Firstname";
    //    str1 = Console.ReadLine();
    //    string valueString1 = str1;

    //    Console.WriteLine("Please Enter your Address, house number and town");
    //    string str3 = "Address";
    //    str3 = Console.ReadLine();
    //    string valueString3 = str3;

    //    Console.WriteLine("Please Enter your County");
    //    string str5 = "County";
    //    str5 = Console.ReadLine();
    //    string valueString5 = str5;

    //    Console.WriteLine("Please Enter your Postcode");
    //    string str6 = "Postcode";
    //    str6 = Console.ReadLine();
    //    string valueString6 = str6;



    //    Console.WriteLine("Here is a list of the stored names and addresees that you have entered so far");
    //    Console.WriteLine("******************************************************************************");
    //    //Console.ReadLine();





    //    Console.WriteLine("Lastname you entered: " + valueString2);
    //    Console.WriteLine("Firstname you entered: " + valueString1);
    //    Console.WriteLine("Address and house number and town you entered: " + valueString3);
    //    Console.WriteLine("County you entered: " + valueString5);
    //    Console.WriteLine("Postcode you entered: " + valueString6);
    //    //Console.ReadLine();
    //}

public class Person
{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string[] Addresses { get; set; }

    public static List<Person> People = new List<Person>();


    public static void AddPerson()
    {
        Person person = new Person();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        person.PhoneNumber = Console.ReadLine();

        Console.Write("Enter Address 1: ");
        string[] addresses = new string[2];
        addresses[0] = Console.ReadLine();
        Console.Write("Enter Address 2 (Optional): ");
        addresses[1] = Console.ReadLine();
        person.Addresses = addresses;

        People.Add(person);
    }
    public static void PrintPerson(Person person)
    {
        Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);
        Console.WriteLine("Phone Number: " + person.PhoneNumber);
        Console.WriteLine("Address 1: " + person.Addresses[0]);
        Console.WriteLine("Address 2: " + person.Addresses[1]);
        Console.WriteLine("-------------------------------------------");
    }


    public static void ListPeople()
    {
        if (People.Count == 0)
        {
            Console.WriteLine("Your address book is empty. Press any key to continue.");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Here are the current people in your address book:\n");
        foreach (var person in People)
        {
            PrintPerson(person);
        }
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();

        
    }

    public static void RemovePerson()
    {
        Console.WriteLine("Enter the first name of the person you would like to remove.");

        string firstName = Console.ReadLine();
        Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());

        if (person == null)
        {
            Console.WriteLine("That person could not be found. Press any key to continue");
            Console.ReadKey();
        }
        Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
        PrintPerson(person);

        if (Console.ReadKey().Key == ConsoleKey.Y)
        {
            People.Remove(person);
            Console.WriteLine("Person removed. Press any key to continue.");
            Console.ReadKey();
        }
    }
    public static void show()
    {
        string command = "";
        while (command != "exit")
        {
            Console.Clear();
            Console.WriteLine("Please enter one of the following command: add,remove or list ");
            command = Console.ReadLine().ToLower();
            switch (command)
            {
                case "add":
                    AddPerson();
                    break;
                case "remove":
                    RemovePerson();
                    break;
                case "list":
                    ListPeople();
                    break;
            }
        }
    }
       
}

//}

