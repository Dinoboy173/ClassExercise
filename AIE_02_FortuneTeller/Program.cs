using System;

namespace AIE_02_FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned int (only posative values)
            uint numberOfChildren = 10;
            string partnersName = "Bob";
            string geographicLocation = "Sydney";
            string jobTitle = "Forklift Driver";

            uint broken = numberOfChildren - 11;

            string output = string.Format(
                "You will be an {0} in {1}, and married to {2} with {3} kids",
                jobTitle, geographicLocation, partnersName, broken);

            Console.WriteLine(output);
        }
    }
}