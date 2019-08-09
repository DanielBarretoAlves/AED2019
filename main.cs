using System;

class MainClass {
  public static void Main (string[] args) {
    int numero1;
    int numero2;
    int numero3;
    int numeroMaior;
    Console.WriteLine("informe um numero");
    numero1 = int.Parse(Console.ReadLine());
    numeroMaior = numero1;
    Console.WriteLine("informe outro numero");
    numero2 = int.Parse(Console.ReadLine());
    if(numero2 > numeroMaior){
      numeroMaior = numero2;
    }
    Console.WriteLine("informe outro numero");
    numero3 = int.Parse(Console.ReadLine());
    if(numero3 > numeroMaior){
      numeroMaior = numero3;
    }
    Console.WriteLine("O Maior numero é: " + numeroMaior);

  }
}