using System;

namespace Lukas_Rose_SUT21___Labb_2___Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu m = new Menu();
            Animal[] a = {new Cat("Sally", 4.05f, 21.2f, "svart"),
                          new Snake("Emil", 7.5f, 15.0f, 3.5f),
                          new Shepherd("Bentley", 35.7f, 61.2f, false),
                          new Corgi("Paul", 10.5f, 26.4f, true) };
            m.RunMainMenu(a);
        }
    }
}
