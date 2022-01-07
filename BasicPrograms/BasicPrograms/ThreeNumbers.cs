using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThreeNumbers
{
    public static void ThreeNumbers1()
    {
        int a, b, c;
        Console.WriteLine("Enter Three Numbers");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine()); 
        c = int.Parse(Console.ReadLine());
        if((a > b) && (a > c)){
            Console.WriteLine(a + " is largest");
        }
        if ((b > a) && (b > c)){
            Console.WriteLine(b + " is largest");
        }
        if ((c > a) && (c > b)){
            Console.WriteLine(c + " is largest");
        }
    }
}

