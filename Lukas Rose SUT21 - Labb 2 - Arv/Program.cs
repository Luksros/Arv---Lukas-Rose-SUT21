using System;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] allAnimals = {new Cat("Sally", 4.05f, 21.2f, "svart"),
                                   new Snake("Emil", 7.5f, 13.2f, 2.9f),
                                   new Shepherd("Bentley", 35.7f, 61.2f, false),
                                   new Corgi("Paul", 10.5f, 26.4f, true)};

            int counter = 0;
            foreach (Animal animal in allAnimals)
            {
                counter++;
                Console.Clear();

                Console.WriteLine(animal +"\n");
                animal.RunAllMethods();

                System.Threading.Thread.Sleep(1200);

                Console.WriteLine((counter < allAnimals.Length) ? "\nTryck Enter för att se nästa djur." : "\nTryck Enter för att avsluta.");
                Console.ReadLine();
            }     
        }
    }
}
