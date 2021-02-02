using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }

    abstract class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }//in minutes
        public Genre Category { get; set; }

        public List<string> Scenes { get; set; }

       
        public Movie(string Title, int RunTime, Genre Category, List<string> Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
            
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Run Time: {RunTime} minutes");
            Console.WriteLine($"Genre: {Category}\n");
        }

        public void PrintScenes()
        {
            Console.WriteLine($"\nList of Scenes: {Title}");

            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"\tScene {i}");
            }
        }

        public abstract void Play();

        //public override string ToString()
        //{
        //    string output = "";
        //    output += $"Title: {Title}\n";
        //    output += $"Run Time: {RunTime}\n";
        //    output += $"Genre: {Category}\n";
        //    return output;
        //}

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
    

