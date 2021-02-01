using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    class DVD : Movie
    {
        public DVD(string Title, int RunTime, Genre Category, List<string> Scenes) : base(Title, RunTime, Category, Scenes)
        {
            
        }

        public override void Play()
        {
            Console.WriteLine("Which scene would you like to watch?");
            PrintScenes();

            string userInput = Console.ReadLine();
            int option;

            for (int i = 0; i < Scenes.Count; i++)
            {
                while (true)
                {
                    if (Int32.TryParse(userInput, out option))
                    {
                        if(i == option)
                        {
                            Console.WriteLine($" Scene [{i}]: {Scenes[i]}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please input one of the scene numbers.");
                    }
                }
            }
        }




        public void PlayWholeMovie()
        {

        }
    }
}
