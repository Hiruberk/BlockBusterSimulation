using System;

namespace Blockbuster_Movie_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blockbuster!");
            Blockbuster b = new Blockbuster();
            b.CheckOut();

            Console.Write("Do you want to watch the movie? Y/N ");
            string userInput = Console.ReadLine().Trim().ToLower();

            while (true)
            {
                if (userInput == "y" || userInput == "yes")
                {
                   
                    break;
                }
                else if (userInput == "n" || userInput == "no")
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Please select Yes or No.");
                }
            }
        }
    }
}
