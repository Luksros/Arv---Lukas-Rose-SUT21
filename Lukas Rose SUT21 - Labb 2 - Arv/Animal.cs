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
        public List <string> menu = new List<string>();
        public string description;
        public string aniType;
        public Animal(string nameIn, float weightIn, float heightIn)
        {
            name = nameIn;
            weight = weightIn;
            height = heightIn;
        }

        //These methods will be inherited by all the animals
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(name + ((numOfLegs > 1) ? " springer runt lite..." : " kan inte springa, men försöker i alla fall kräla runt lite..."));
            Console.ReadLine();
        }
        public void WagTail()
        {
            Console.Clear();
            Console.WriteLine(name + ((hasTail) ? " viftar lite på svansen..." : " har ingen svans att vifta på..."));
            Console.ReadLine();
        }
        public void Nap()
        {
            Console.Clear();
            Console.WriteLine(name + " tar en liten tupplur...");
            string sleep = "Z z z . . .";
            for (int i = 0; i < sleep.Length; i++)
            {
                System.Threading.Thread.Sleep(280);
                Console.Write(sleep[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public virtual void MakeSound()
        {

        }
        public virtual void Unique()
        {

        }
        public virtual void Unique2()
        {
            
        }  
    }
}
