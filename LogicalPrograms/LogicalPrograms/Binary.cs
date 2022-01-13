using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Binary
{

    public static void toBinary(int decimalNumber)
    {
        int g = 1, j = 0, binary = 0; ;
        while (decimalNumber != 0)
        {
            int remainder = decimalNumber % 2;
            decimalNumber /= 2;
            binary = binary + (remainder * g);
            g *= 10;
        }
        Console.WriteLine(binary);
        ;

        int afterSwapNumber = ((binary & 0x0F) << 4 |
            (binary & 0xF0) >> 4);
        Console.WriteLine(afterSwapNumber);

        static bool isPowerOfTwo(int n)
        {
            return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2))))
                  == (int)(Math.Floor(((Math.Log(n) / Math.Log(2)))));
        }
        if (isPowerOfTwo(afterSwapNumber))
        {
            Console.WriteLine("Yes");
        }
        else
            Console.WriteLine("No");
    }
}

