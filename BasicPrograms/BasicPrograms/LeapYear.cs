using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LeapYear
{
       public static void LeapYear1()
       {
            int number;
            Console.WriteLine("Enter Year");
            number = int.Parse(Console.ReadLine());
            if (number > 999 && number < 10000)
            {
                if (number % 400 == 0)
                {
                    Console.WriteLine("leap year");
                }
                else if (number % 100 == 0)
                {
                    Console.WriteLine("not leap year");
                }
                else if (number % 4 == 0)
                {
                    Console.WriteLine("leap year");
                }
                else
                {
                    Console.WriteLine("not leap year");
                }
            }
        else
        {
            Console.WriteLine("year is not 4 digit");
        }
       } 
}

