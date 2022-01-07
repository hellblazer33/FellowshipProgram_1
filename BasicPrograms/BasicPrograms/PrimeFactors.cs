using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrimeFactors
{
    public static void PrimeFactors1()
    {
        int n = 0;
        Console.WriteLine("Enter number for its prime factors");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Prime factors are ");
        for (int i = 1; i <= Math.Sqrt(n * n); i++)
        {
            if (n % i == 0)
            {
                Console.Write(i + " ");

            }
        }

    }
}

