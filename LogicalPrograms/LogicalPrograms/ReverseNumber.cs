using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReverseNumber
{
    public static void ReverseNumber1()
    {
        int number, reversedNumber = 0;
        Console.WriteLine("Enter Number to be reversed");
        number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }
        Console.WriteLine(reversedNumber);
    }

}

