using System;
namespace snakeAndLadder
{
	public class PlayerSnakeAndLadder
	{
        public static void PlayerSnakeAndLadder1()
        {

            int position1 = 0;
            int position2 = 0;
            int diceRoll = 0;
            int flag = 0;

            const int noPlay = 1;
            const int ladder = 3;
            const int snake = 5;

            while (position1 < 100 || position2 < 100)
            {
                Random random = new Random();    //UC3
                int diceNumber1 = random.Next(1, 7);
                int diceNumber2 = random.Next(1, 7);

                if(diceNumber1 == noPlay)
                {
                    //nothing happen
                }
                if(diceNumber2 == noPlay)
                {
                    //nothing happen
                }
                if(diceNumber1 == ladder)
                {
                    position1 = 0;  //player 1 plays again
                }
                if(diceNumber2 == ladder)
                {
                    position2 = 0;  //player 2 plays again
                }
                if (position1 == snake)
                {
                    position1 = position1 - 5;
                }
                if (position2 == snake)
                {
                    position2 = position2 - 5;
                }
                if (diceNumber1 == 2)
                {
                    position1 = position1 + 2;
                }
                if (diceNumber2== 2)
                {
                    position2 = position2 + 2;
                }
                if (diceNumber1 == 4)
                {
                    position1 = position1 + 4;
                }
                if (diceNumber2 == 4)
                {
                    position2 = position2 + 4;
                }
                if (diceNumber1 == 6)
                {
                    position1 = position1 + 6;
                }
                if (diceNumber2 == 6)
                {
                    position2 = position2 + 6;
                }
                if (position1 >= 100)
                {
                    flag = 1;
                    break;
                  //Console.WriteLine("Player 1 wins");
                }
                else if (position2 >= 100)
                {
                    flag = 2;
                    break;
                 // Console.WriteLine("Player 2 wins");
                }
            }
                if(flag==1)
            {
                Console.WriteLine("Player 1 wins");
            }
               else if(flag==2)
            {
                Console.WriteLine("Player 2 wins");
            }
                //Console.WriteLine("You won");   //UC4
                //Console.WriteLine("position " + position); //UC5
                //Console.WriteLine("No. of dice rolls " + diceRoll); //UC6
        



        }
    }
}

