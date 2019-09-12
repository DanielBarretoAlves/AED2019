using System;
namespace Desafio_ex7_2_ex17
{
    public class tamagushi
    {
        private string nome;
        private int fome;
        private int saude;
        private int idade;
        private int humor;
        private int energia;
        private bool vivo = true;

        public string Nome { get => nome; set => nome = value; }
        public int Fome { get => fome; set => fome = value; }
        public int Saude { get => saude; set => saude = value; }
        public int Idade { get => idade; set => idade = value; }
        public int Energia { get => energia; set => energia = value; }
        public void showStats()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Fome: " + fome);
            Console.WriteLine("Saude: " + saude);
            Console.WriteLine("Humor: " + humor);
            Console.WriteLine("Energia: " + energia);
            Console.WriteLine("Idade: " + idade);
        }
        public void quantidadeComida()
        {
            int quantidade = int.MinValue;
            Console.WriteLine("Informe a quantidade de comida");
            quantidade = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                alimentar();
            }
        }
        public void calcHumor()
        {
            humor = fome + saude;
        }
        public void alimentar()
        {
            fome++;
            energia--;
        }
        public void tempoBricadeira()
        {
            int playTime = int.MinValue;
            Console.WriteLine("Informe a quantidade de tempo que vai brincar:");
            playTime = int.Parse(Console.ReadLine());
            for (int i = 0; i < int.MinValue; i++)
            {
                brincar();
            }
        }
        public void brincar()
        {
            humor++;
            fome--;
            energia--;
        }
        public void dormir()
        {
            energia++;
            fome--;
            humor--;
        }
        public void sleepTime()
        {
            Console.WriteLine("Informe o tempo que deseja dormir:");
            int sleepTime = int.Parse(Console.ReadLine());
            for (int i = 0; i < int.MinValue; i++)
            {
                dormir();
            }
        }
        public void checkSaude()
        {
            if (saude == 0)
            {
                vivo = false;

            }
        }
        public void redPill()
        {
            string passCode = string.Empty;
            Console.WriteLine("Insert Password");
            passCode = Console.ReadLine();
            if (passCode == "matrix")
            {
                saude = saude + 10;
                Console.WriteLine("Saude: +10");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Fome: " + fome);
                Console.WriteLine("Saude: " + saude);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Humor: " + humor);
                Console.WriteLine("Energia: " + energia);
                Console.WriteLine("Vivo: " + vivo);
            }
        }
    }
}

//Classe Bichinho Virtual++: Melhore o programa do bichinho virtual,
//    permitindo que o usuário especifique quanto de comida ele fornece
//    ao bichinho e por quanto tempo ele brinca com o bichinho.Faça com
//    que estes valores afetem quão rapidamente os níveis de fome e tédio caem.




