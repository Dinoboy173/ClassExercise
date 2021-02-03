using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            string password = "";
            string matchingPassword = "";

            do
            {
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                Console.Write("Confirm a password: ");
                matchingPassword = Console.ReadLine();

            } while (password != matchingPassword);

            Console.WriteLine("Your password has been leaked to the world");
            Console.WriteLine("Exiting");
        }
    }
}
