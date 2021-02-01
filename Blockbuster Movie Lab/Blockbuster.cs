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
            List<string> shrekScenes = new List<string>() {"Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> knivesScenes = new List<string>() { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> avengerScenes = new List<string>() { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> conjuringScenes = new List<string>() { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> hereditaryScenes = new List<string>() { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };
            List<string> fiftyDatesScenes = new List<string>() { "Scene 0", "Scene 1", "Scene 2", "Scene 3", "Scene 4", "Scene 5" };

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

        public void CheckOut()
        {
            PrintMovies();
            Console.Write("Please select a movie you want to watch: ");

            int option;
            string userInput = Console.ReadLine();

            for (int i = 0; i < Movies.Count; i++)
            {
                while (true)//Turn this into a validcheck method instead, remove the while into another method. so the for loop can just select which movie to display
                {
                    if (Int32.TryParse(userInput, out option))
                    {
                        if (i == option-1)
                        {
                            Movies[i].PrintInfo();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please input one of the scene numbers.");
                            userInput = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please input a number.");
                        userInput = Console.ReadLine();
                    }
                }
            }
        }

    }
}
