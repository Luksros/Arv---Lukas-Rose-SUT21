using System;
using System.Collections.Generic;
using System.Text;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    public abstract class Animal
    {
        //These fields will be inherited by all of the animals
        public string name;
        public float weight;
        public float height;
        public int numOfLegs;
        public bool hasTail;
        public string description;
        public Animal(string nameIn, float weightIn, float heightIn)
        {
            name = nameIn;
            weight = weightIn;
            height = heightIn;
        }

        //These methods will be inherited by all the animals
        public void Run()
        {
            Console.WriteLine(name + ((numOfLegs > 1) ? " springer runt lite..." : " kan inte springa, men försöker i alla fall kräla runt lite..."));
        }
        public void WagTail()
        {
            Console.WriteLine(name + ((hasTail) ? " viftar lite på svansen..." : " har ingen svans att vifta på..."));
        }
        public void Nap()
        {
            Console.Write(name + " tar en liten tupplur... ");
            string sleep = "Z z z . . .";
            for (int i = 0; i < sleep.Length; i++)
            {
                System.Threading.Thread.Sleep(109);
                Console.Write(sleep[i]);
            }
            Console.WriteLine();
        }

        public virtual void MakeSound()
        {

        }

        //RunAllMethods is overridden by all the Child-classes, and runs all the child-classes available methods
        public virtual void RunAllMethods()
        {

        }
        public override string ToString()
        {
            return description;
        }
        
    }
}
