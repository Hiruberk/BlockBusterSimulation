using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public VHS(string Title, int RunTime, Genre Category, List<string> Scenes) : base(Title, RunTime, Category, Scenes)
        {
            Rewind();
        }

        public override void Play()
        {

            for (int i = CurrentTime; i < Scenes.Count; i++)
            {
                Console.WriteLine($" Scene [{i}]: {Scenes[i]}");
                CurrentTime++;
            }

            if(CurrentTime > 0)
            {
                Console.WriteLine("Would you like to rewind? Yes or No?");
                string userInput = Console.ReadLine();
                
                if(userInput == "Yes")
                {
                    Rewind();
                }
                else
                {
                    Console.WriteLine("You're that guy, well...alright.");
                    Rewind();
                }

            }
                 
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }

        public void PlayWholeMovie()
        {

        }

    }
}
