using System;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Mischa = new Cat("Mischa", 4.10f, 25.00f, "Sköldpaddsfärgad");
            Mischa.Run();
            Mischa.MakeSound();
            Mischa.WagTail();
            Mischa.Nap();
            Mischa.Purr();
            Console.ReadLine();
            Console.Clear();

            Snake Bentley = new Snake("Bentley", 7.14f, 3.23f);
            Bentley.Run();
            Bentley.WagTail();
            Bentley.Nap();
            Bentley.MakeSound();
            Bentley.Shed();
            Console.ReadLine();
            Console.Clear();

            Corgi Paul = new Corgi("Paul", 15.00f, 35.00f, true);
            Paul.Run();
            Paul.MakeSound();
            Paul.WagTail();
            Paul.Nap();
            Paul.Spin();
            Console.ReadLine();
            Console.Clear();

            Shepherd Jerry = new Shepherd("Jerry", 35.00f, 60.00f, false);
            Jerry.Run();
            Jerry.MakeSound();
            Jerry.WagTail();
            Jerry.Nap();
            Jerry.Bite();
            Console.ReadLine();

        }
    }
    class Animal
    {
        public string name;
        public float weight;
        public float height;
        public int numOfLegs;
        public bool hasTail;

        public void Run()
        {
            if (numOfLegs > 1)
            {
                Console.WriteLine(name + " springer runt lite...");
            }
            else
            {
                Console.WriteLine(name + " kan inte springa, men försöker i alla fall kräla runt lite...");
            }
        }
        public void WagTail()
        {
            if (hasTail)
            {
                Console.WriteLine(name + " viftar lite på svansen...");
            }
            else
            {
                Console.WriteLine(name + " har ingen svans att vifta på...");
            }
        }
        public void Nap()
        {
            Console.WriteLine(name + " tar en liten tupplur...");
            string sleep = "Z z z . . .";
            for (int i = 0; i < sleep.Length; i++)
            {
                System.Threading.Thread.Sleep(280);
                Console.Write(sleep[i]);
            }
            Console.WriteLine();
        }

        //public void PrintMenu(string[] menuStrings)
        //{
        //    Console.WriteLine("Vad vill du att {0} ska göra? Välj genom att skriva siffra och tryck Enter.", name);
        //    Console.WriteLine();
        //    for (int i = 0; i < menuStrings.Length; i++)
        //    {
        //        Console.WriteLine("[" + i + "] " + menuStrings[i]);
        //    }
        //}
    }
    class Cat : Animal
    {
        public string furColour;
        //public string[] catMenu = { "Springa runt", "Vifta på svansen", "Ta en tupplur", "Gör ett läte", "Spinn", "Återgå till huvudmeny" };
        public Cat(string catName, float catWeight, float catHeight, string colourIn)
        {
            name = catName;
            weight = catWeight;
            height = catHeight;
            numOfLegs = 4;
            hasTail = true;
            furColour = colourIn;
            Console.WriteLine("{0} är en {1} katt som väger {2} kg och är {3} cm hög.", name, furColour, weight, height);
        }
        public void MakeSound()
        {
            Console.WriteLine(name + " låter: Mjau!");
        }
        public void Purr()
        {
            Console.WriteLine(name + " känner sig säker och spinner lite. Prrr...");
        }
    }
    class Snake : Animal
    {
        public float length;
        public Snake(string snakeName, float snakeWeight, float lengthIn)
        {
            name = snakeName;
            weight = snakeWeight;
            length = lengthIn;
            hasTail = true;
            numOfLegs = 0;
            Console.WriteLine("{0} är en {1} meter lång orm som väger {2} kg.", name, length, weight);
        }

        public void MakeSound()
        {
            Console.WriteLine(name + " låter. Sss-s-s!");
        }
        public void Shed()
        {
            string[] shedStrings = { (name + " ömsar sitt skinn"), " .", " .", " ." };
            for (int i = 0; i < shedStrings.Length; i++)
            {               
                Console.Write(shedStrings[i]);
                System.Threading.Thread.Sleep(280);
            }
            Console.WriteLine();
        }
    }
    abstract class Dog : Animal
    {
        public bool isBigDog;
        public Dog(string dogName, float dogWeight, float dogHeight)
        {
            name = dogName;
            weight = dogWeight;
            height = dogHeight;
            numOfLegs = 4;   
            Console.WriteLine("{0} är en {1} hund som väger {2} kg och är {3} cm hög.", name, ((isBigDog) ? "stor" : "liten"), weight, height);
        }

        public void MakeSound()
        {
            if (isBigDog)
            {
                Console.WriteLine(name + " skäller till ordentligt: VOFF!");
            }
            else
            {
                Console.WriteLine(name + " släpper ur sig ett litet skall: Arf!");
            }
        }
        public void Fetch()
        {
            Console.WriteLine("Du kastar iväg en boll, {0} springer efter den i full fart!", name);
            for (int i = 0; i < 6; i++)
            {
                System.Threading.Thread.Sleep(280);
                Console.Write(". ");
            }
            Console.WriteLine();
            Console.WriteLine(name + " kommer skuttande tillbaka med bollen i munnen!");
        }
    }
    class Corgi : Dog
    {
        bool trained;
        public Corgi(string corgiName, float corgiWeight, float corgiHeight, bool corgitrained) : base(corgiName, corgiWeight, corgiHeight)
        {
            hasTail = false;
            isBigDog = false;
            trained = corgitrained;
        }
        public void Spin()
        {
            if (trained)
            {
                Console.WriteLine(name + " är väldresserad och skuttar runt lite i en cirkel...");
            }
            else
            {
                Console.WriteLine(name + " fattar ingenting och står bara och stirrar på dig...");
            }
            
        }
    }
    class Shepherd : Dog
    {
        bool aggressive;
        public Shepherd(string shepName, float shepWeight, float shepHeight, bool shepAggressive) : base(shepName, shepWeight, shepHeight)
        {
            hasTail = true;
            isBigDog = true;
            aggressive = shepAggressive;
        }
        public void Bite()
        {
            if (aggressive)
            {
                Console.WriteLine(name + " är en snäll hund och nafsar på din hand lite lätt...");
            }
            else
            {
                Console.WriteLine(name + " blir lite till sig och biter din hand rätt hårt. Ouch!");
            }
            
        }
    }
}
