using System;

namespace Blockbuster_Movie_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blockbuster!");
            Blockbuster b = new Blockbuster();//grabs all the movies that were intialized in Blockbuster class
            int index = b.CheckOut();//Prints movies asks which one you want

            Console.Write("Are you sure you want to watch this movie? Y/N  ");//Confirms choice
            string userInput = Console.ReadLine().Trim().ToLower();

            while (true)//checks that userInput is a valid response
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
            //This determines which path they take in the next while loop
            string full = Console.ReadLine().ToLower().Trim();

            while (true)
            {
                Movie m = b.GetMovie(index);
                string input = "" ;//intilization for second user input determining if they want to go again

                if (full == "full")
                {
                    m.PlayWholeMovie();// Plays full movie

                    Console.Write("\nWould you like to watch another movie? Y/N  ");
                    input = Console.ReadLine().Trim().ToLower();

                    if (input == "n" || input == "no" || userInput == "n" || userInput == "no")//If they don't say no they must want to watch more
                    {
                        Console.WriteLine("\nGoodbye, thanks for stopping in");//Closes program
                        break;
                    }
                    else
                    {
                        index = b.CheckOut();//Calls the main movie list back
                        Console.Write("\nWould you like to view each scene separately or the full movie? (Full/Scenes)  ");
                        full = Console.ReadLine().ToLower().Trim();//Determines which path they will go in the next iteration of the while loop
                    }

                }
                else if (full == "scenes")
                {
                    m.Play();//Scene by scene

                    Console.Write("\nWould you like to watch another movie? Y/N  ");
                    input = Console.ReadLine().Trim().ToLower();

                    if (input == "n" || input == "no" || userInput == "n" || userInput == "no")//If they came into a Bluckbuster they must by default want to watch more
                    {
                        Console.WriteLine("\nGoodbye, thanks for stopping in");//Closes program
                        break;
                    }
                    else
                    {

                    }

                    index = b.CheckOut();//Calls the main movie back
                    Console.Write("\nWould you like to view each scene separately or the full movie? (Full/Scenes)  ");
                    full = Console.ReadLine().ToLower().Trim();//Determines which path they will go in the next iteration of the while loop
                }
                else
                {
                    Console.Write("Please enter Full or Scenes, no exceptions.  ");//Make sure they go down either Full or scenes path
                    full = Console.ReadLine().ToLower().Trim();
                }
            }
        }
    }
}
