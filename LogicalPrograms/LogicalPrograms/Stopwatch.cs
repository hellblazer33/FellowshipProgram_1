using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stopwatch
{
    public static void Stopwatch1()
    {
        int time1,time2,diff=0;
        Console.WriteLine("Enter start time in XXXX hours format");
        time1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter stop time in XXXX hours format");
        time2 = int.Parse(Console.ReadLine());
        diff = time2 - time1;
        Console.WriteLine("Difference in time is " + diff);
    }
}

