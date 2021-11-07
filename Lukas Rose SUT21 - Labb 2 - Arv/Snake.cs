using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Snake : Animal
    {
        //This field is unique to the Snake Child-class
        public float length;
        public Snake(string snakeName, float snakeHeight, float snakeWeight, float lengthIn) : base(snakeName, snakeWeight, snakeHeight)
        {
            name = snakeName;
            weight = snakeWeight;
            length = lengthIn;
            hasTail = true;
            numOfLegs = 0;
            description = (name + " är en " + length + " meter lång orm som väger " + weight + " kg.");
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + " låter. Sss-s-s!");
        }

        //This method is unique to the Snake Child-class
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
            Shed();
        }
    }
}
