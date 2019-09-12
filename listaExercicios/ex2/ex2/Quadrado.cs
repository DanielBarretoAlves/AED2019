using System;
namespace ex2
{
    public class Quadrado
    {
        private int tamanhoL;

        public Quadrado(int tamanhoL)
        {
            this.tamanhoL = tamanhoL;
        }
        public void setTamanhoL(int tamanhoL)
        {
            this.tamanhoL = tamanhoL;
        }
        public int getTamanhoL()
        {
            return tamanhoL;
        }
        public void changeTamanhoL()
        {
            Console.WriteLine("Informe o novo tamanho");
            tamanhoL = int.Parse(Console.ReadLine());
        }
        public int calcArea()
        {
            return tamanhoL * 4;
        }
            

    }
}
