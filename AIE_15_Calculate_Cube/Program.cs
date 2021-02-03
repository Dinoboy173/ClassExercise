using System;
namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            string sA = Console.ReadLine();
            int a = int.Parse(sA);

            Console.WriteLine(CalculateCube(a));
        }
        static int CalculateCube(int a)
        {
            int value = (a * a * a);
            return value;
        }
    
    }
}