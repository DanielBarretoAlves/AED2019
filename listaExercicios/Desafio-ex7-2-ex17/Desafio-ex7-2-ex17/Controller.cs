using System;
namespace Desafio_ex7_2_ex17
{
    public class Controller
    {
        tamagushi player = new tamagushi();

        public void showActions()
        {
            int choise = int.MinValue;
            bool isVallid = false;
            while (isVallid != true)
            {
                player.showStats();
                player.checkSaude();
                Console.WriteLine("1 - Alimentar");
                Console.WriteLine("2 - Brincar");
                Console.WriteLine("3 - Dormir");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        player.quantidadeComida();
                        isVallid = true;
                        break;
                    case 2:
                        player.tempoBricadeira();
                        isVallid = true;
                        break;
                    case 3:
                        player.sleepTime();
                        isVallid = true;
                        break;
                    case 0:
                        player.redPill();
                        isVallid = true;
                        break;
                    default:
                        Console.WriteLine("Comando Inválido!");
                        break;
                }
            }
        }

        public void eventTick()
        {
            bool aplicationRunning = true;
            while (aplicationRunning == true)
            {
                showActions();
                Console.Clear();

            }

        }

        public void beginPlay()
        {
            player.Fome = 20;
            player.Saude = 100;
            player.Energia = 20;
            player.Idade = 0;
        }
    }
}
