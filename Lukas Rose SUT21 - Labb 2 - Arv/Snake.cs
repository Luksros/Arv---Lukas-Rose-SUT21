using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Snake : Animal
    {
        public float length;
        public Snake(string snakeName, float snakeHeight, float snakeWeight = 5.00f, float lengthIn = 3.00f) : base(snakeName, snakeWeight, snakeHeight)
        {
            name = snakeName;
            weight = snakeWeight;
            length = lengthIn;
            hasTail = true;
            numOfLegs = 0;
            menu.AddRange("[1] Springa runt,[2] Vifta på svansen,[3] Ta en tupplur,[4] Gör ett läte,[5] Ömsa skinn,[6] Återgå till huvudmeny".Split(','));
            description = (name + " är en " + length + " meter lång orm som väger" + weight + " kg.");
        }

        public override void MakeSound()
        {
            Console.Clear();
            Console.WriteLine(name + " låter. Sss-s-s!");
            Console.ReadLine();
        }
        public override void Unique()
        {
            Console.Clear();
            string[] shedStrings = { (name + " ömsar sitt skinn"), " .", " .", " ." };
            for (int i = 0; i < shedStrings.Length; i++)
            {
                Console.Write(shedStrings[i]);
                System.Threading.Thread.Sleep(280);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
