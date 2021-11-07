using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Shepherd : Dog
    {
        //This field is unique to the Shepherd Child-class, which inherits from Dog, which inherits from Animal
        bool aggressive;
        public Shepherd(string shepName, float shepWeight, float shepHeight, bool shepAggressive) : base(shepName, shepWeight, shepHeight)
        {
            hasTail = true;
            isBigDog = true;
            aggressive = shepAggressive;
            description = (name + " är en stor Schäfer-hund som är " + height + " cm hög och väger " + weight + " kg.");
        }
        //This field is unique to the Shepherd Child-class
        public void Bite()
        {
            Console.WriteLine(name + (aggressive ? " blir lite till sig och biter din hand rätt hårt. Ouch!" 
                                                 : " är en snäll hund och nafsar på din hand lite lätt..."));
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
            Bite();
        }
    }
}
