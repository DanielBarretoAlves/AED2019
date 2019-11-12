using System;
using System.Collections;
using System.IO;
class reader
{
//Construtor Vazio
  public reader()
  {

  }
  public void ReadFiles()
  {
    using(StreamReader reader  = new StreamReader(@"files.txt"))
    {
      while(!reader.EndOfStream)
      {
        string linha = reader.ReadLine();
        Console.WriteLine(linha);
      }
    }
    
    
  
  }
}