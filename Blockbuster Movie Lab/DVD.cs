using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    class DVD : Movie
    {
        public DVD(string Title, int RunTime, Genre Category, List<string> Scenes)
            : base(Title, RunTime, Category, Scenes)
        {
            
        }

        public override void Play()
        {
            while (true)
            {
                PrintScenes();
                Console.Write($"\nWhich scene in {Title} would you like to watch? Select 1 to {Scenes.Count}:  ");
                string userInput = Console.ReadLine();
                int option = ValidCheck(userInput, 1, Scenes.Count);

                for (int i = 0; i < Scenes.Count; i++)
                {

                    if (i == option-1)
                    {
                        Console.WriteLine($"\n\tScene [{option}]: {Scenes[i]}");
                        break;
                    }
                }

                Console.Write("\nWould you like to watch another scene? Y/N  ");
                string again = Console.ReadLine().ToLower();

                if (again == "n" || again == "no")
                {
                    break;
                }

            }
        }




        public override void PlayWholeMovie()
        {
            Console.WriteLine("\nPlease turn off your cell phone and enjoy the movie.");
            for (int i = 0; i < Scenes.Count; i++)
            {
                    Console.WriteLine($"\n\tScene [{i+1}]: {Scenes[i]}");
            }
        }
    }
}
