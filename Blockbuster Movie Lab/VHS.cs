using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Blockbuster_Movie_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes)
            : base(Title, RunTime, Category, Scenes)
        {
            CurrentTime = 0;//All new VHS tapes start from beginning
        }

        public override void Play()
        {
            while (true)
            {
                if(CurrentTime == Scenes.Count)
                {
                    Console.WriteLine("\nSorry, someone didn't rewind. Let me get that for you.");
                    CurrentTime = 0;//Makes it so a out of index range is not thrown, imagine a guy
                                    // in the back rewinding all the non rewinded VHS tapes
                }

                Console.WriteLine($"\nScene [{CurrentTime+1}]: {Scenes[CurrentTime]}\n"); //Prints a single scene.
                CurrentTime++;//Jumps to next index

                if (CurrentTime == Scenes.Count)
                {
                    Console.WriteLine($"\nI am sorry, but that is the end of {Title}");
                    Rewind();//Calls the rewind function from below
                    break;
                }

                Console.Write("\nWould you like to watch more? Y/N  " );
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "no" || userInput == "n")
                {
                    if (CurrentTime > 0)
                    {
                        Rewind();//Before you go you really should rewind
                                // even if you didn't watch all the movie
                    }
                    break;
                }
            }
        }

        public void Rewind()
        {
            Console.Write("\nWould you like to rewind? Yes or No?  ");//Tries to get them to rewind or set CurrentTime to 0
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

        public override void PlayWholeMovie()//Plays all the scenes one after another
        {
            Console.WriteLine("\nPlease turn off your pager and enjoy the movie.");
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"\n\tScene [{i+1}]: {Scenes[i]}");
                Thread.Sleep(1500);//To simulate a real movie
            }
        }

    }
}
