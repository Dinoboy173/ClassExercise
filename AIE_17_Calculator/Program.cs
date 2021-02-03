using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string sNum1 = Console.ReadLine();
            float num1 = float.Parse(sNum1);
           
            Console.Write("Enter another number: ");
            string sNum2 = Console.ReadLine();
            float num2 = float.Parse(sNum2);

            Console.Write("Enter an expression. add, sub, mul, div: ");
            string operation = Console.ReadLine();


            Console.WriteLine(Calculate(num1, num2, operation)); 
        }

        static float Calculate(float num1, float num2, string operation)
        {
            float value = 0;

            if (operation == "add")
            {
                value = num1 + num2;
            }
            else if(operation == "sub")
            {
                value = num1 - num2;
            }
            else if(operation == "mul")
            {
                value = num1 * num2;
            }
            else if(operation == "div")
            {
                value = num1 / num2;
            }
            return value;
        }
    }
}