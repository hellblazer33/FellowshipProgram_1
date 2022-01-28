// See https://aka.ms/new-console-template for more information
using RegexPattern;

//Console.WriteLine("Hello, World!");
Patterns patterns = new Patterns();
//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
//if (patterns.validateEmail("abc+100@gmail.com"))
//{
//    Console.WriteLine("Valid");
//}
//else
//    Console.WriteLine("Invalid");
//if (patterns.validateFirstName("Pankaj"))
//{
//    Console.WriteLine("Valid");
//}
//else
//    Console.WriteLine("Invalid");
//if (patterns.validateLastName("Kumar"))
//{
//    Console.WriteLine("Valid");
//}
//else
//    Console.WriteLine("Invalid");
//if (patterns.validateMobile("91 7883773486"))
//{
//    Console.WriteLine("Valid");
//}
//else
//    Console.WriteLine("Invalid");
if (patterns.password("Pasd@456"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();