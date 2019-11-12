using System;

class MainClass {
  public static void Main (string[] args) {
    int[,] myArray = new int [5,2];
    for(int i = 0; i < 5; i++)
    {
      for(int j = 0; j < 2; j++)
      {
        Console.WriteLine("Informe o numero");
        myArray[i, j] = int.Parse(Console.ReadLine());
      }
    }

    for(int i = 0; i < 5; i++)
    {
      for(int j = 0; j < 2; j++)
      {
        Console.Write(myArray[i, j] + " ");
      }
      Console.WriteLine(" ");
    }
  }
}