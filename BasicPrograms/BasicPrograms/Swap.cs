using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Swap
{
    public static void Swap1()
    {
        int temp=0,a=0,b=0;
        Console.WriteLine("Enter value of a and b");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("value of a is " + a);
        Console.WriteLine("value of b is " + b);
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("after swapping value of a is " + a);
        Console.WriteLine("after swapping value of b is " + b);

    }
}

