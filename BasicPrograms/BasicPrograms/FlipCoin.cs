using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class FlipCoin
{
    public static void FlipCoin1()
    {
        double coinFlip,tailCount=0,headCount=0,tailPerc=0,headPerc=0;
        for (int i = 0; i < 10; i++)
        {
            Random random = new Random();
            coinFlip = random.Next(0, 2);
            //Console.WriteLine(coinFlip);
            if (coinFlip < 0.5)
            {
                tailCount = tailCount + 1;
                Console.WriteLine("Tails");
            }
            else
            {
                headCount = headCount + 1;
                Console.WriteLine("Heads");
            }
        }
        //Console.WriteLine(headCount);
        double totalCount = tailCount + headCount;
        //Console.WriteLine(totalCount);
        tailPerc = (tailCount / totalCount) * 100;
        headPerc = (headCount / totalCount) * 100;
        Console.WriteLine("Tail Percentage " + tailPerc);
        Console.WriteLine("Head Percentage "+ headPerc);
        //Console.WriteLine(headPerc);
    }


}

