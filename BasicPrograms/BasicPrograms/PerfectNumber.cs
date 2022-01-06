using System;
using System.Collections.Generic;
     public class PerfectNumber
    {
        public static void PerfectNumber1()
        {
            int number,sum=0;
            Console.WriteLine("Enter Number");
            number = int.Parse(Console.ReadLine());
            for(int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    sum += i;
                }
            }
            if(sum == number)
            {
            Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
            }
        }

    }

