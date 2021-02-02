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

                if (userInput == "y" || userInput == "yes")
                {
                    m.Play();
                    
                }
                else if (userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("\nGoodbye, thanks for stopping in");
                    break;
                }
                else
                {
                    Console.Write("\nPlease select Yes or No.  ");
                }

                Console.Write("\nWould you like to watch another movie? Y/N  ");
                string Input = Console.ReadLine().Trim().ToLower();

                index = b.CheckOut();
            }
        }
    }
}
