// See https://aka.ms/new-console-template for more information
int[] intArray = { 2,4,5,6,8};
char[] charArray = { 'H','E','L','L','O'};
double[] doubleArray = {1.1,3.3,5.5,8.7};
//DisplayInt(intArray);
//DisplayChar(charArray);
//DisplayDouble(doubleArray);

DIsplay<int>(intArray);
DIsplay<char>(charArray);
DIsplay<double>(doubleArray);

Console.ReadKey();



 static void DisplayInt(int[] test)
{
    for(int i = 0; i < test.Length; i++)
    {
        Console.Write(test[i] + " ");
    }
    Console.WriteLine();
}

 static void DisplayChar(char[] test)
{
    for (int i = 0; i < test.Length; i++)
    {
        Console.Write(test[i] + " ");
    }
    Console.WriteLine();
}

 static void DisplayDouble(double[] test)
{
    for (int i = 0; i < test.Length; i++)
    {
        Console.Write(test[i] + " ");
    }
    Console.WriteLine();
}

static void DIsplay<T>(T[] test)
{
    for (int i = 0; i < test.Length; i++)
    {
        Console.Write(test[i] + " ");
    }
    Console.WriteLine();
}