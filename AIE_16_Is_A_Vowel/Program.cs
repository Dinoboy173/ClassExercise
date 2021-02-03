using System;
namespace HelloWorld
{
    class Program
    {
        // TODO: Write the MaxOfThree function here

        static void Main(string[] args)
        {
            Console.WriteLine(MaxOfThree(6, 9, 1)); // should output 9 
            Console.WriteLine(MaxOfThree(20, 20, 20)); // should output 20
            Console.WriteLine(MaxOfThree(6, 1, 6)); // should output 6 
        }

        static int MaxOfThree(int a, int b, int c)
        {
            if (a >= b && a >= c) return a;
            if (b >= a && b >= c) return b;
            else return c;
        }
    }
}