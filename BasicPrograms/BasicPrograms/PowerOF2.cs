using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PowerOF2
{
    public static void PowerOf2Program()
    {
        double n=0,number=0;
        Console.WriteLine("Enter value of n less than 31");
        n = double.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            number = Math.Pow(2, i);
            Console.Write(number + " ");
        }
    }
}

