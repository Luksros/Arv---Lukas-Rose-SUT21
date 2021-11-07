using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{

    ///För rättning av labben kan den här klassen helt ignoreras, den är bara till för att göra testningen av programmet mer interaktiv. 
    public class Menu
    {
        public int selector;
        public List<String> mainMenu = new List<string>() {"Vilket djur vill du interagera med?",
                                                           "Välj genom att skriva motsvarande siffra och trycka Enter.",
                                                           " "," " };
        public List<string> animalMenu = new List<string>() {"Vad vill du att detta djur ska göra?",
                                                           "Välj genom att skriva motsvarande siffra och trycka Enter."," "};
        public void PrintMenu(List<string> menuIn)
        {
            foreach(string section in menuIn)
            {
                Console.WriteLine(section);
            }
        }
        public void PrintMenu(List<string> menuIn, Animal thisAnimal)
        {
            Console.WriteLine(thisAnimal.description);
            foreach (string section in menuIn)
            {
                Console.WriteLine(section);
            }
            foreach (string section in thisAnimal.menu)
            {
                Console.WriteLine(section);
            }
        }
        public void RunMainMenu(Animal[] theseAnimals)
        {
            bool keepRunning;
            do
            {
                keepRunning = true;
                
                do //As long as the user inputs something invalid, the menu keeps reprinting, until a valid selection is made. 
                {
                    Console.Clear();
                    PrintMenu(mainMenu);
                    for (int i = 0; i <= theseAnimals.Length; i++)
                    {
                        //This if-else is here to make the length of the menu modular, to make coding the program easier.
                        //Basically just means that I don´t have to go back and change the code, if I were to add more animals.
                        if (i < theseAnimals.Length) 
                        {
                            Console.WriteLine("[{0}] {1} ({2})", i + 1, theseAnimals[i].name, theseAnimals[i].aniType);
                        }
                        else //When there are no animals left to print out, the end of the menu is printed. 
                        {
                            Console.WriteLine();
                            Console.WriteLine("[{0}] Avsluta", i + 1);
                        }
                    }
                } while ((!int.TryParse(Console.ReadLine(), out selector)) || ((selector < 1 || selector > theseAnimals.Length + 1)));

                if (selector <= theseAnimals.Length)
                {
                    RunAnimalMenu(theseAnimals[selector-1]);
                }
                else
                {
                    keepRunning = false;
                }
            } while (keepRunning);
            
        }
        public void RunAnimalMenu(Animal thisAnimal)
        {
            bool runAgain = true;
            while (runAgain)
            {             
                do
                {
                    Console.Clear();
                    PrintMenu(animalMenu, thisAnimal);

                } while (!int.TryParse(Console.ReadLine(), out selector));

                switch (selector)
                {
                    case 1:
                        thisAnimal.Run();
                        break;
                    case 2:
                        thisAnimal.WagTail();
                        break;
                    case 3:
                        thisAnimal.Nap();
                        break;
                    case 4:
                        thisAnimal.MakeSound();
                        break;
                    case 5:
                        thisAnimal.Unique();
                        break;
                    case 6: //Since corgi and shepherd have one more method than the other animals (having inherited from both animal and dog),
                            //the if-clauses on case 6 and 7 check the size (amount of strings) of the menu, and then execute accordingly.  
                        if (thisAnimal.menu.Count > 6)
                        {
                            thisAnimal.Unique2();
                        }
                        else
                        {
                            runAgain = false;
                            Console.Clear();
                        }
                        break;
                    case 7:
                        if (thisAnimal.menu.Count > 6)
                        {
                            runAgain = false;
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ogiltigt val. Försök igen.");
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ogiltig val. Försök igen.");
                        break;
                }
            }
        }
    }
}
