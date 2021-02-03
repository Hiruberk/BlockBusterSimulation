using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
                PrintScenes();//First it prints the scenes
                Console.Write($"\nWhich scene in {Title} would you like to watch? Select 1 to {Scenes.Count}:  ");//Then user selects a scene
                string userInput = Console.ReadLine();
                int option = ValidCheck(userInput, 1, Scenes.Count);//Selection is double checked

                for (int i = 0; i < Scenes.Count; i++)
                {//Since this is a DVD it will play any scene you select, so it will iterate through until selection matches index and prints.

                    if (i == option-1)
                    {
                        Console.WriteLine($"\n\tScene [{option}]: {Scenes[i]}");
                        break;
                    }
                }

                Console.Write("\nWould you like to watch another scene? Y/N  ");//See if they want to hop around the DVD for more scenes.
                string again = Console.ReadLine().ToLower();

                if (again == "n" || again == "no")
                {
                    break;//If they are done breaks and jumps back to the "main menu" in the main method
                }

            }
        }




        public override void PlayWholeMovie()//Plays all the scenes at once.
        {
            Console.WriteLine("\nPlease turn off your cell phone and enjoy the movie.");
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"\n\tScene [{i+1}]: {Scenes[i]}");
                Thread.Sleep(1500);//Makes it a little slow to resemble a movie playing
            }
        }
    }
}
