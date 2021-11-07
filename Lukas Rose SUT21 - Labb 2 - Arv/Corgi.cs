using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Corgi : Dog
    {
        //This field is unique to the Corgi Child-class, which inherits from Dog, which inherits from Animal
        bool trained;
        public Corgi(string corgiName, float corgiWeight, float corgiHeight, bool corgitrained) : base(corgiName, corgiWeight, corgiHeight)
        {
            hasTail = false;
            isBigDog = false;
            trained = corgitrained;
            description = (name + " är en liten Corgi-hund som är " + height + " cm hög och väger " + weight + " kg.");
        }

        //This method is unique to the Corgi Child-class
        public void Prance()
        {
            Console.WriteLine(name + ((trained) ? " är väldresserad och skuttar runt lite i en cirkel..."
                                                : " fattar ingenting och står bara och stirrar på dig..."));
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
            Fetch();
            System.Threading.Thread.Sleep(1200);
            Prance();
        }
    }
}
