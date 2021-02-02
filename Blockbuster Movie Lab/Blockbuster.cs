using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            Movies = new List<Movie>();
            List<string> shrekScenes = new List<string>() 
                {"Shrek Hanging out in the Swamp", "Shrek meets Donkey", "Shrek walks up into a castle", "Shreak befriends a dragon", "Shrek gets lucky", "Back to swamp and all is happy" };
            List<string> knivesScenes = new List<string>() 
                { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> avengerScenes = new List<string>() 
                { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> conjuringScenes = new List<string>() 
                { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> hereditaryScenes = new List<string>() 
                { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> fiftyDatesScenes = new List<string>() 
                { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };

            Movie shrek = new VHS("Shrek", 95, Genre.Comedy, shrekScenes);
            Movie knivesOut = new DVD("Knives Out", 130, Genre.Drama, knivesScenes);
            Movie avengers = new DVD("Avengers", 144, Genre.Action, avengerScenes);
            Movie conjuring = new VHS("The Conjuring", 112, Genre.Horror, conjuringScenes);
            Movie hereditary = new DVD("Hereditary", 127, Genre.Horror, hereditaryScenes);
            Movie fiftyDates = new VHS("50 First Dates", 96, Genre.Romance, fiftyDatesScenes);

            Movies.Add(shrek);
            Movies.Add(knivesOut);
            Movies.Add(avengers);
            Movies.Add(conjuring);
            Movies.Add(hereditary);
            Movies.Add(fiftyDates);
          }

        public void PrintMovies()
        {
            
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"\t[{i+1}.] {Movies[i].Title}");
            }
        }

        public int CheckOut()
        {
            PrintMovies();
            Console.Write("\nPlease select a movie you want to watch:  ");

            
            string userInput = Console.ReadLine();

            for (int i = 0; i < Movies.Count; i++)
            {
                int option = ValidCheck(userInput, 0 , Movies.Count);

                if (i == option-1)
                {
                    Movies[i].PrintInfo();
                    return i;
                    
                }
            }
            int index = 1;
            return index;
        }

        public Movie GetMovie(int index)
        {
            return Movies[index];
        }

        public virtual int ValidCheck(string input, int min, int max)
        {
            int integer;
            while (true)
            {
                if (Int32.TryParse(input, out integer))//Checks if it can be converted to a number
                {
                    if (integer >= min && integer <= max)//Checks that it is within the given range
                    {
                        return integer;// returns a valid integer
                    }
                    else
                    {
                        Console.Write("\nPlease enter a number that is on the list!  ");//requires them to keep trying until they give a valid entry
                        input = Console.ReadLine();
                    }

                }
                else
                {
                    Console.Write("\nPlease enter a number.  ");//requires them to keep trying until they give a valid entry
                    input = Console.ReadLine();
                }
            }
        }
    }
}
