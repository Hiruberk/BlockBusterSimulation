using System;

namespace Blockbuster_Movie_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blockbuster!");
            Blockbuster b = new Blockbuster();
            int index = b.CheckOut();

            Console.Write("\nDo you want to watch the movie? Y/N  ");
            string userInput = Console.ReadLine().Trim().ToLower();

            //Movie m = b.GetMovie(index);
           

            while (true)
            {
                Movie m = b.GetMovie(index);
                string input = "" ;

                if (userInput == "y" || userInput == "yes" || input == "y" || input == "yes")
                {
                    m.Play();
                    
                }
                else
                {
                    Console.Write("\nPlease select Yes or No.  ");
                }

                Console.Write("\nWould you like to watch another movie? Y/N  ");
                input = Console.ReadLine().Trim().ToLower();

                if(input == "n" || input == "no" || userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("\nGoodbye, thanks for stopping in");
                    break;
                }

                index = b.CheckOut();
            }
        }
    }
}
