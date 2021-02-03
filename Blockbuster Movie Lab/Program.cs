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

            Console.Write("Do you want to watch this movie? Y/N  ");
            string userInput = Console.ReadLine().Trim().ToLower();

            while (true)
            {
                if (userInput == "y" || userInput == "n" || userInput == "yes" || userInput == "no")
                {
                    break;
                }
                else
                {
                    Console.Write("\nPlease select Yes or No.  ");
                    userInput = Console.ReadLine().Trim().ToLower();
                }
            }

            Console.Write("\nWould you like to view each scene separately or the full movie? (Full/Scenes)  ");
            string full = Console.ReadLine().ToLower().Trim();

            while (true)
            {
                Movie m = b.GetMovie(index);
                string input = "" ;

                if (full == "full")
                {
                    m.PlayWholeMovie();

                    Console.Write("\nWould you like to watch another movie? Y/N  ");
                    input = Console.ReadLine().Trim().ToLower();

                    if (input == "n" || input == "no" || userInput == "n" || userInput == "no")
                    {
                        Console.WriteLine("\nGoodbye, thanks for stopping in");
                        break;
                    }
                    else
                    {
                        index = b.CheckOut();
                        Console.Write("\nWould you like to view each scene separately or the full movie? (Full/Scenes)  ");
                        full = Console.ReadLine().ToLower().Trim();
                    }

                }
                else if (full == "scenes")
                {
                    m.Play();

                    Console.Write("\nWould you like to watch another movie? Y/N  ");
                    input = Console.ReadLine().Trim().ToLower();

                    if (input == "n" || input == "no" || userInput == "n" || userInput == "no")
                    {
                        Console.WriteLine("\nGoodbye, thanks for stopping in");
                        break;
                    }
                    else
                    {

                    }

                    index = b.CheckOut();
                    Console.Write("\nWould you like to view each scene separately or the full movie? (Full/Scenes)  ");
                    full = Console.ReadLine().ToLower().Trim();
                }
                else
                {
                    Console.Write("Please enter Full or Scenes, no exceptions.  ");
                    full = Console.ReadLine().ToLower().Trim();
                }
            }
        }
    }
}
