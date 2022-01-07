using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Harmonic
{
    public static void Harmonic1()
    {
        double N=0,sum=0;
        Console.WriteLine("Enter Harmonic N");
        N = double.Parse(Console.ReadLine());
        for(int i = 1; i <= N; i++)
        {
            Console.Write("1/{0} + ", i);
            sum = sum + 1 / (float)i;
        }
        Console.WriteLine("is "+ sum);
    }

}

