using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Cat : Animal
    {
        public string furColour;

        public Cat(string catName, float catWeight, float catHeight, string colourIn) : base(catName, catWeight, catHeight)
        {
            name = catName;
            weight = catWeight;
            height = catHeight;
            numOfLegs = 4;
            hasTail = true;
            furColour = colourIn;
            menu.AddRange("[1] Springa runt,[2] Vifta på svansen,[3] Ta en tupplur,[4] Gör ett läte,[5] Spinn,[6] Återgå till huvudmeny".Split(','));
            description = (name + " är en " + furColour + " katt som är " + height + " cm hög och väger " + weight + " kg.");
        }
        public override void MakeSound()
        {
            Console.Clear();
            Console.WriteLine(name + " låter: Mjau!");
            Console.ReadLine();
        }
        public override void Unique()
        {
            Console.Clear();
            Console.WriteLine(name + " känner sig säker och spinner lite. Prrr...");
            Console.ReadLine();
        }
    }
}
