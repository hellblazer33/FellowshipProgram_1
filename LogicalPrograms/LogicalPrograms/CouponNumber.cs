using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CouponNumber
{
    public static void CouponNumber1()
    {
        int numberOfCoupons, i, count = 0, count2 = 0;
        int[] ran = new int[10];
        Console.WriteLine("Enter Number of Coupons for which number of random numbers to be calculated");
        numberOfCoupons = int.Parse(Console.ReadLine());
        for (i = 0; i < numberOfCoupons; i++)
        {
            Random random = new Random();
            ran[i] = random.Next();
            for (int j = 0; j < numberOfCoupons; j++)
            {
                if (ran[i] == ran[j])
                {
                    count++;
                    if (count > 1)
                    {
                        count2++;
                        count = 0;
                    }
                }
            }
        }
        count2 = count2 + numberOfCoupons;
        Console.WriteLine(count2);

    }
}
