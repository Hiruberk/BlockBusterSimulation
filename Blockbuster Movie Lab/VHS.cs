﻿using System;
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
                Console.WriteLine($"\nScene [{CurrentTime}]: {Scenes[CurrentTime]}\n");
                CurrentTime++;

                Console.Write("\nWould you like to watch more? Y/N  " );
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "no" || userInput == "n")
                {
                    break;
                }
            }

            if(CurrentTime > 0)
            {
                Rewind();
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
                Console.WriteLine("You're that guy, well...alright.");

            }
        }

        public void PlayWholeMovie()
        {

        }

    }
}
