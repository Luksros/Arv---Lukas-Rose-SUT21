using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    abstract class Dog : Animal
    {
        public bool isBigDog;
        public Dog(string dogName, float dogWeight, float dogHeight) : base(dogName, dogWeight, dogHeight)
        {
            name = dogName;
            weight = dogWeight;
            height = dogHeight;
            numOfLegs = 4;
        }

        public override void MakeSound()
        {
            Console.Clear();
            Console.WriteLine(name + ((isBigDog) ? " skäller till ordentligt: VOFF!"
                                                 : " släpper ur sig ett litet skall: Arf!"));
            Console.ReadLine();
        }
        public override void Unique()
        {
            Console.Clear();
            Console.WriteLine("Du kastar iväg en boll, {0} springer efter den i full fart!", name);
            for (int i = 0; i < 6; i++)
            {
                System.Threading.Thread.Sleep(280);
                Console.Write(". ");
            }
            Console.WriteLine();
            Console.WriteLine(name + " kommer skuttande tillbaka med bollen i munnen!");
            Console.ReadLine();
        }
    }
}
