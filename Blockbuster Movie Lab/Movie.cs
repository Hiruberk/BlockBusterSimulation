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

    class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }//in minutes
        public Genre Category { get; set; }

        public List<string> Scenes = new List<string>();

       
        public Movie(string Title, int RunTime, Genre Category, List<string> Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes;
            
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Run Time: {RunTime} minutes");
            Console.WriteLine($"Genre: {Category}\n");
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count - 1; i++)
            {
                Console.WriteLine($"List of Scenes: {Title}");
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }
        
        public virtual void Play()
        {
            //Needs to be abstract when we learn that. Sublcasses will utilize this.
        }


        //public override string ToString()
        //{
        //    string output = "";
        //    output += $"Title: {Title}\n";
        //    output += $"Run Time: {RunTime}\n";
        //    output += $"Genre: {Category}\n";
        //    return output;
        //}


    }
}
    

