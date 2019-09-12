using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado square = new Quadrado(5);
            square.changeTamanhoL();
            Console.WriteLine("Tamanho de um Lado: " + square.getTamanhoL());
            Console.WriteLine("A area do quadrado: " + square.calcArea());
        }
    }
}
