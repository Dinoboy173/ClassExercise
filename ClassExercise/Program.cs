using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            int multiplier = 9;
            int number = 0;

            while (number < 11)
            {
                int answer = multiplier * number;
                Console.WriteLine(number + " * 9 = " + answer);
                number = number + 1;
            }
        }
    }
}
