using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie_Lab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public Blockbuster()
        {
            Movies = new List<Movie>();//My apologies for this wall of text when defining the scenes. File IO would've been useful to declutter this.
            List<string> shrekScenes = new List<string>() 
                {"Shrek Hanging out in the Swamp.", "Shrek meets Donkey.", "Shrek walks up into a castle.", "Shreak befriends a dragon.", "Shrek gets lucky.", "Back to swamp and all is happy." };
            List<string> knivesScenes = new List<string>() 
                { "A Rich guy dies...mysteriously.", "A smort detective arrives to figure it out.", "Everybody lies to the detective.", "The detective starts putting pieces together.",
                    "THE TWIST!", "Detective figured the whole thing out and everyone is astounished!" };
            List<string> avengerScenes = new List<string>() 
                { "Aliens are real!", "Aliens have a sour disposition towards Earth.", "Samuel L. Jackson calls in Superheroes.", "The heroes become divided!",
                    "Scarlett Johnanson as Black Widow!", "The hulk shows up and beats up the bad guys.", "UN Fires Nukes.", "Nukes don't work.", "Superheroes win....or do they?" };
            List<string> conjuringScenes = new List<string>() 
                { "Scared dog is at a farmhouse riddled with children.", "The spooky levels intensify.", "Dog dies, birds start killing themselves on windows!",
                    "The Warren's are called, the baddest demon slayers in the land!", "Flash back! A witch and baby died in a murder-suicide involving the Devil!",
                "A doll attacks a child!" , "Young sisters try to murder each other!", "Exorcism.", "The Warren's take the music box and leave." };
            List<string> hereditaryScenes = new List<string>() 
                { "Utah funeral.", "A lot of subtext towards strange traits passed on through mothers.", "A highschool party where a child eats peanuts and it is not okay.",
                    "Anti-Peanut Child is decapitated!", "Sister of Peanut Child is not doing real good.", "Things get way crazier!", "Charlie turned out to be one of the 8 kings of Hell." };
            List<string> fiftyDatesScenes = new List<string>() 
                { "Many women talk about having sex with the Adam Sandler.", "Adam Sandler works at aquarium with a walrus!",
                    "Adam Sandler pursues Drew Barrymore, but she broke her brain.", "Broken brain Drew Barrymore learns her brain is broken.","Drew Barrymore gets real mad at Adam Sandler.",
                    "Drew Barrymore paints many pictures of Adam Sandler, but doesn't know why.", "Suddenly, Broken brain Drew Barrymore has a toddler with Adam Sandler on a boat!" };
            List<string> airplaneScenes = new List<string>() { "Taxi driver throws water at his face.", "He boards plane after stalking ex-girlfriend.", "Everyone gets reeeaaalll sick.", 
                    "Taxi driver takes over the plane.", "Taxi driver calls a friend to ask how to land the plane, but just has flashbacks.", "Taxi driver mostly lands the plan, but gets his girlfriend back."};
            List<string> jawsScenes = new List<string>() { "Opens up on to a large body of water. It is the ocean.", "The princess's boyfriend is a pirate!", "Princess gets kidnapped by, for lack of a better term, the three stooges.",
                    "Pirate boyfriend shows up and takes off into the forest full of large rodents.", "Pirate boyfriend is mostly dead, but partially alive!",
                    "Wedding and Princess has suicidal attempt.", "Pirate and Princess passionately kiss.", "The little boy asks his grandfather to reread the story."};

            Movie shrek = new VHS("VHS Shrek", 95, Genre.Comedy, shrekScenes);
            Movie knivesOut = new DVD("DVD Knives Out", 130, Genre.Drama, knivesScenes);
            Movie avengers = new DVD("DVD Avengers", 144, Genre.Action, avengerScenes);
            Movie conjuring = new VHS("VHS The Conjuring", 112, Genre.Horror, conjuringScenes);
            Movie hereditary = new DVD("DVD Hereditary", 127, Genre.Horror, hereditaryScenes);
            Movie fiftyDates = new VHS("VHS 50 First Dates", 96, Genre.Romance, fiftyDatesScenes);
            Movie airplane = new VHS("VHS Airplane!", 87, Genre.Comedy, airplaneScenes);
            Movie jaws = new DVD("DVD Jaws", 124, Genre.Drama, jawsScenes);

            Movies.Add(shrek);
            Movies.Add(knivesOut);
            Movies.Add(avengers);
            Movies.Add(conjuring);
            Movies.Add(hereditary);
            Movies.Add(fiftyDates);
            Movies.Add(airplane);
            Movies.Add(jaws);
          }

        public void PrintMovies()
        {
            
            for (int i = 0; i < Movies.Count; i++)//Iterates through the Movies list that is defined above
            {
                Console.WriteLine($"\t[{i+1}.] {Movies[i].Title}");//Prints ever index in Movies
            }
        }

        public int CheckOut()//Start of the program
        {
            PrintMovies();//Prints all the movies to select from
            Console.Write("\nPlease select a movie you want to watch:  ");

            
            string userInput = Console.ReadLine();

            for (int i = 0; i < Movies.Count; i++)//Iterates through the movies.
            {
                int option = ValidCheck(userInput, 1 , Movies.Count+1);//Checks that a number on the list was entered properly

                if (i == option-1)//Since all the options are +1 to index it brings it back to match the right index of the list
                {
                    Movies[i].PrintInfo();//returns the index and prints the movie description
                    return i;
                    
                }
            }
            int index = 1;
            return index;
        }

        public Movie GetMovie(int index)//Grabs the user selected movie
        {
            return Movies[index];
        }

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
