using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Shepherd : Dog
    {
        bool aggressive;
        public Shepherd(string shepName, float shepWeight, float shepHeight, bool shepAggressive) : base(shepName, shepWeight, shepHeight)
        {
            hasTail = true;
            isBigDog = true;
            aggressive = shepAggressive;
            Console.WriteLine("{0} är en stor Schäfer som väger {1} kg och är {2} cm hög.", name, weight, height);
            menu.AddRange("[1] Springa runt,[2] Vifta på svansen,[3] Ta en tupplur,[4] Gör ett läte,[5] Apport,[6] Nafsa,[7] Återgå till huvudmeny".Split(','));
            description = (name + " är en stor Schäfer som är " + height + " cm hög och väger " + weight + " kg.");
            aniType = "Schäfer(Hund)";
        }
        public override void Unique2()
        {
            Console.Clear();
            Console.WriteLine(name + (aggressive ? " blir lite till sig och biter din hand rätt hårt. Ouch!" 
                                                 : " är en snäll hund och nafsar på din hand lite lätt..."));
            Console.ReadLine();
        }
    }
}
