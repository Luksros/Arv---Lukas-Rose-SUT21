using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Corgi : Dog
    {
        bool trained;
        public Corgi(string corgiName, float corgiWeight, float corgiHeight, bool corgitrained) : base(corgiName, corgiWeight, corgiHeight)
        {
            hasTail = false;
            isBigDog = false;
            trained = corgitrained;
            menu.AddRange("[1] Springa runt,[2] Vifta på svansen,[3] Ta en tupplur,[4] Gör ett läte,[5] Apport,[6] Snurra runt,[7] Återgå till huvudmeny".Split(','));
            description = (name + " är en liten Corgi som är " + height + " cm hög och väger " + weight + " kg.");

        }
        public override void Unique2()
        {
            Console.Clear();
            Console.WriteLine(name + ((trained) ? " är väldresserad och skuttar runt lite i en cirkel..."
                                                : " fattar ingenting och står bara och stirrar på dig..."));
            Console.ReadLine();
        }
    }
}
