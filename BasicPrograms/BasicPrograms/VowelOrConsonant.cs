using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VowelOrConsonant
{
    public static void VowelOrConsonant1()
    {
        char character;
        Console.WriteLine("Enter character in captital letter to check for vowel or consonant");
        character = char.Parse(Console.ReadLine());
        if ((character == 'A') || (character == 'E') || (character == 'I') || (character == 'O') || (character == 'U'))
        {
            Console.WriteLine("Vowel");

        }
        else
        {
            Console.WriteLine("Consonant");
        }
    }
}

