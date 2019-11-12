using System;
using System.IO;
//using System.Collection;
class writer
{
//Variaveis
  private static string user = "admin";
  private static string password = "password";
//Construtor Vazio
  public writer()
  {
    
  }
//Adding new Person to The List
  public void addGuest()
  {
    using(StreamWriter writer = new StreamWriter(@"files.txt"))
    {
      string str = string.Empty;
      Console.WriteLine(@"Informe a Lista de Nomes Ou escreva 'sair'! ");

      while(str != "sair"){
        str = Console.ReadLine();

        //Realiza a gravação da linha de texto dentro do arquivo:
        if(str != "sair") writer.WriteLine(str);
    }
    }
  }
//Accessing class
  public void access()
  {
    string pass, us;
    bool key = true;
    while(key == true)
    {
      Console.WriteLine("Informe o User Name:");
      us = Console.ReadLine();
      Console.WriteLine("Informe o Password:");
      pass = Console.ReadLine();
      if(us == user && pass == password)
      {
        Console.WriteLine("Acesso Permitido!");
        key = false;
        addGuest();
      }else
      {
        Console.WriteLine("Username ou Password estão errados");
      }
    }
  }


}