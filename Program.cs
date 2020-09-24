using System;

namespace VHarmanTech3a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write line to instruct user to input their first and last name
            Console.WriteLine("Please input your first and last name ...");

            string input = Console.ReadLine();
            try
            {
                Hello_User(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid string of characters...");
            }
        }
        private static void Hello_User(string input)
        {
            //Try catch blocked used to validiate input is proper string
            try
            {
                
                //Write line to say hello followed by the users name input
                Console.WriteLine("Hello " + input + "!");
                Console.WriteLine("Press any key to exit...");

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid string of characters...");
                Console.WriteLine("Press any key to exit and try again ...");
                Console.ReadKey(true);
            }
        }

    }
}
