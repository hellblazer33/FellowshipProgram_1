using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Util
{
    public static void dayOfWeek(int m,int d, int y)
    {
        int y0 = y - ((14 - m) / 12);
        int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + ((31 * m0) / 12)) % 7;
        Console.WriteLine(d0);
        switch (d0)
        {
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
        }
            

    }
    public static void temperatureConversion()
    {
        double far, cel;
        Console.WriteLine("Enter temp in celcius or farenheit to convert");
        Console.WriteLine("Enter 1 for celcius to farenheit");
        Console.WriteLine("Enter 2 for farencheit to celcius");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter celclus temperature");
                cel = double.Parse(Console.ReadLine());
                far = cel * 9/5 + 32;
                Console.WriteLine("Temperature in farenheit is "+ far);
                break;

            case 2:
                Console.WriteLine("Enter farenheit temperature");
                far = double.Parse(Console.ReadLine());
                cel = (far - 32) * 5/9;
                Console.WriteLine("Temperature in celcius is "+ cel);
                break;
            default:
                Console.WriteLine("Choose 1 or 2 only");
                break;
        }
        


    }
    public static void monthlyPayment(double P, double Y,double R)
    {
        double r = R / (12 * 100);
        double n = 12 * Y;
        double payment = P * r / (1 - Math.Pow(1 + r, -n));
        Console.WriteLine("Montly payment to be done is "+ payment);
    }
}

