using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class QuotientAndRemainder
{
    public static void QuotientAndRemainder1()
    {
        int number = 0,divisor=0,Quotient=0,remainder=0;
        Console.WriteLine("Enter Number"); 
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Divisor");
        divisor = int.Parse(Console.ReadLine());
        Quotient = number/divisor;
        remainder = number%divisor;
        Console.WriteLine("Quotient is "+ Quotient);
        Console.WriteLine("Remainder is "+ remainder);
    }
}

