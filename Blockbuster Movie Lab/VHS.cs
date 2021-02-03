using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes)
            : base(Title, RunTime, Category, Scenes)
        {
            CurrentTime = 0;
        }

        public override void Play()
        {
            while (true)
            {
                if(CurrentTime == Scenes.Count)
                {
                    Console.WriteLine("\nSorry, someone didn't rewind. Let me get that for you.");
                    CurrentTime = 0;
                }

                Console.WriteLine($"\nScene [{CurrentTime+1}]: {Scenes[CurrentTime]}\n"); 
                CurrentTime++;

                if (CurrentTime == Scenes.Count)
                {
                    Console.WriteLine($"\nI am sorry, but that is the end of {Title}");
                    Rewind();
                    break;
                }

                Console.Write("\nWould you like to watch more? Y/N  " );
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "no" || userInput == "n")
                {
                    if (CurrentTime > 0)
                    {
                        Rewind();
                    }
                    break;
                }
            }
        }

        public void Rewind()
        {
            Console.Write("\nWould you like to rewind? Yes or No?  ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y" || userInput == "yes")
            {
                CurrentTime = 0;
            }
            else
            {
                Console.WriteLine("\nYou're that guy, well...alright.");

            }
        }

        public override void PlayWholeMovie()
        {
            Console.WriteLine("\nPlease turn off your pager and enjoy the movie.");
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"\n\tScene [{i+1}]: {Scenes[i]}");
            }
        }

    }
}
