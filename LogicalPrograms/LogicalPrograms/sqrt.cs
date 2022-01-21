using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Sqrt
{

        // Function to return the square root of
        // a number using Newtons method
        public static void squareRoot()
        {
            double num, tolerence;
            Console.WriteLine("Enter number for which root is to be calculated");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tolerence level");
            tolerence = double.Parse(Console.ReadLine());
            
            double x = num;
            double root;
            int count = 0;

            while (true)
            {
                count++;

                // Calculate more closed x
                root = 0.5 * (x + (num / x));

                // Check for closeness
                if (Math.Abs(root - x) < tolerence)
                    break;

                // Update root
                x = root;
            }

            Console.WriteLine("Root is " + root);
        }
 }
