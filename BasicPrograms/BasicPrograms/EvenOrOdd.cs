using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EvenOrOdd
{
    public static void EvenOrOdd1()
    {
        int number;
        Console.WriteLine("Enter number to check for even or odd");
        number = int.Parse(Console.ReadLine());
        if(number % 2 == 0)
        {
            Console.WriteLine("Even");

        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}

