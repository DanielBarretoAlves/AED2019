using System;
// Alunos Daniel e Matheus
class MainClass 
{
  public static void Main (string[] args) 
  {
    float qtdCandidatos;
    float qtdVotos = 0;
    bool key = true;
    string input;

    while(key == true)
  {
    Console.WriteLine("Digite 0 Para Sair - Qualquer tecla para continuar");
    input =Console.ReadLine();
    if(input == "0"){
      key = false;
    }




    Console.WriteLine("Quantidade de Candidatos");
    qtdCandidatos = float.Parse(Console.ReadLine());
    string[] nomesCandidatos = new string [qtdCandidatos];
    float[] votoCandidatos = new float [qtdCandidatos];
    float[] porcCandidatos = new float [qtdCandidatos];
    for(int i = 0; i < qtdCandidatos; i++) 
  {
    Console.WriteLine("Informe o nome do cadidato   " + (i+1));
        nomesCandidatos[i] = Console.ReadLine();
  }
    for(int i = 0 ; i < qtdCandidatos; i++)
    {
      Console.WriteLine("Informe a Quantidade de Votos do Candidato " + nomesCandidatos[i]);
      votoCandidatos[i] = float.Parse(Console.ReadLine());
      qtdVotos = qtdVotos + votoCandidatos[i];

    }

    Console.WriteLine("Total de Votos: " + qtdVotos);
    for(int i =0; i < qtdCandidatos ; i++){

      porcCandidatos[i] = ((votoCandidatos[i] / qtdVotos) * 100);
      
      Console.WriteLine("Nome: " + nomesCandidatos[i]);
      Console.WriteLine("Porcentagem de Votos: " + porcCandidatos[i]);
      

      Console.WriteLine(porcCandidatos[i]);

    }





  }
}
}