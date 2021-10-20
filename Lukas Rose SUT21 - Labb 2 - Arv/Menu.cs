using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    public class Menu
    {
        public int selector;
        public List<String> initMenu = new List<string>() {"Vad för djur vill du skapa?",
                                                           "Välj genom att skriva motsvarande siffra och trycka Enter.",
                                                           " ","[1] Katt", "[2] Orm", "[3] Corgi (Hund)", "[4] Schäfer (Hund)" };
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
        public void PrintMenu(List<string> menuStrings, string tempName)
        {
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < menuStrings.Count; i++)
            {
                Console.WriteLine("[" + i + "] " + menuStrings[i]);
            }
        }
        public void RunMainMenu(Animal[] theseAnimals)
        {
            bool keepRunning;
            do
            {
                keepRunning = true;
                Console.Clear();
                Console.WriteLine("Vilket djur vill du interagera med?");
                Console.WriteLine();
                for (int i = 0; i <= theseAnimals.Length; i++)
                {
                    if (i < theseAnimals.Length)
                    {
                        Console.WriteLine("[{0}] " + theseAnimals[i].name, i + 1);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("[{0}] Avsluta", i + 1);
                    }

                }
                while ((!int.TryParse(Console.ReadLine(), out selector)) || ((selector < 0 || selector > theseAnimals.Length+1)))
                {

                }
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
                Console.Clear();
                PrintMenu(animalMenu, thisAnimal);
                while (!int.TryParse(Console.ReadLine(), out selector))
                {

                }
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
                    case 6:
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
