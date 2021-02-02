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
                Console.Write($"\nWhich scene in {Title} would you like to watch? Select 0 to {Scenes.Count - 1}:  ");
                string userInput = Console.ReadLine();
                int option = ValidCheck(userInput, 0, Scenes.Count);

                for (int i = 0; i < Scenes.Count; i++)
                {

                    if (i == option)
                    {
                        Console.WriteLine($"\n\tScene [{i}]: {Scenes[i]}");
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




        public void PlayWholeMovie()
        {

        }
    }
}
