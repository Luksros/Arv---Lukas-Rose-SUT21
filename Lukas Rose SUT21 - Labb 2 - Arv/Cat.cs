using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Cat : Animal
    {
        //This field is unique to the Cat Child-class
        public string furColour;
        public Cat(string catName, float catWeight, float catHeight, string colourIn) : base(catName, catWeight, catHeight)
        {
            name = catName;
            weight = catWeight;
            height = catHeight;
            numOfLegs = 4;
            hasTail = true;
            furColour = colourIn;
            description = (name + " är en " + furColour + " katt som är " + height + " cm hög och väger " + weight + " kg.");
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + " låter: Mjau!");
        }

        //This method is unique to the Cat Child-class
        public void Purr()
        {
            Console.WriteLine(name + " känner sig säker och spinner lite. Prrr...");
        }
        public override void RunAllMethods()
        {
            System.Threading.Thread.Sleep(1200);
            Run();
            System.Threading.Thread.Sleep(1200);
            WagTail();
            System.Threading.Thread.Sleep(1200);
            Nap();
            MakeSound();
            System.Threading.Thread.Sleep(1200);
            Purr();
        }
    }
}
