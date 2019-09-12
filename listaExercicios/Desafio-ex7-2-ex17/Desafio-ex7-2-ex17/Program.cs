using System;

namespace Desafio_ex7_2_ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Controller nuGame = new Controller();
            nuGame.beginPlay();
            nuGame.eventTick();

            //x = new tamagushi();
        }
    }
}
