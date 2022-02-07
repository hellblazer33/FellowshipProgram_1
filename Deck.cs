using System;
namespace DeckOfCards
{
	public class Deck
	{
		public void Deck1()
		{
			string[] save = new string[52];
			int count = 0, j1 = 0, j2 = 0;

			String[] cardType = { "Clubs", "Diamonds", "Hearts", "Spades" };
			String[] cardNumbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 13; j++)
				{
					Random random = new Random();
					//j1= random.Next(0, 13);
					//i1 = random.Next(0, 4);
					save[j1] = cardType[i] + " " + cardNumbers[j];
					j1++;
				}

			}
			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("For player " + i + " ");
				for (int j = 0; j < 13; j++)
				{
					Console.WriteLine(save[j2]);
					j2++;

				}

			}
			//Console.WriteLine(count);
		}
	}
}

