using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Notes
{
   public static void Notes1()
    {
        int amount,notes_count=0;
        int[] notes = { 1000, 500, 100, 50, 10,5,2,1 };
        int[] note_counter = new int[8];
        Console.WriteLine("Enter Amount");
        amount = int.Parse(Console.ReadLine());
        for(int i=0;  i < notes.Length; i++)
        {
            if (amount >= notes[i])
            {
                note_counter[i] = amount / notes[i];
                amount = amount - note_counter[i] * notes[i];
                notes_count += note_counter[i];
            }
        }
        for(int i = 0; i < notes.Length; i++)
        {
            if (note_counter[i] != 0)
            {
                Console.WriteLine(notes[i] + " notes is "+ note_counter[i]);
                
            }
        }
        Console.WriteLine("Total number of notes is " + notes_count);

    }
}

