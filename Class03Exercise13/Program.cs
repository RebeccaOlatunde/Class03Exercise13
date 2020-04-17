using System;

namespace Class03Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String response = "";

            // For int i = 0; i <= 5; i++
            // Console.ReadLine("Enter a number less than 5)");
            // Console.ReadLine("Enter a number less than 12");

            do
            {
                //For loop

                Console.WriteLine("Enter a number");
                var num = Console.ReadLine();
                var number = int.Parse(num);
                for (int i = 0; i < number; i++)
				{
                    Console.WriteLine(i);
				}

                Console.WriteLine("Would you like to continue?y/n");
                response = Console.ReadLine();
            }   while (response == "y");

            Console.WriteLine("Goodbye!");


        }
    }
}
