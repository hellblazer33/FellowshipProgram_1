// See https://aka.ms/new-console-template for more information

using System;
namespace snakeAndLadder
{

    public class Program
    {
       public static void Main(string[] args)
        {
            int position = 0;
            int diceRoll = 0;
             
            const int noPlay = 1;
            const int ladder = 3;
            const int snake = 5;

            while (position < 100)
            {
                Random random = new Random();    //UC3
                int diceNumber = random.Next(1, 7);

                switch (diceNumber)

                {
                    case noPlay:
                        diceRoll += 1;
                        Console.WriteLine("Position " + position);  //UC6
                        break;

                    case ladder:
                        position = position + 3;
                        diceRoll += 1;
                        Console.WriteLine("Position " + position);   //UC6
                        break;

                    case snake:
                        position = position - 5;
                        diceRoll += 1;
                        Console.WriteLine("Position " + position);    //UC6
                        break;

                    default:
                        position = position + diceNumber;
                        diceRoll += 1;
                        Console.WriteLine("Position " + position);   //UC6
                        break;
                }

                if (position <= 0)
                {
                    position = 0;
                }
            }

            Console.WriteLine("You won");   //UC4
            Console.WriteLine("position " + position); //UC5
            Console.WriteLine("No. of dice rolls " + diceRoll); //UC6
            PlayerSnakeAndLadder.PlayerSnakeAndLadder1();   //UC7
        }



    }

}