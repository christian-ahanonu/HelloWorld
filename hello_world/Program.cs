using System;
using System.Threading;

class Program 
{
    static void Main()
    {
        Console.WriteLine("\nHi there! \n");

        Console.WriteLine("Counting to 5: ");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        Console.WriteLine("Hello World!");
    }
}




