using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            string sNumber = Console.ReadLine();

            int number = int.Parse(sNumber);

            if (number%4 == 0)
            {
                Console.WriteLine("Number is divisible by 4");
            }

            if (number%6 == 0)
            {
                Console.WriteLine("Number is divisible by 6");
            }

            if (!(number%6 == 0 || number%4 ==0))
            {
                Console.WriteLine("Number is not divisible by 4 or 6");
            }

        }
    }
}