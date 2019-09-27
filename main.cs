using System;
using System.Collections.Generic;



class MainClass {
  public static void Main (string[] args) {

    Cartao meuCard = new Cartao(350);
    Maquina maquininha = new Maquina("CINEMA");
    
    if (maquininha.inserirCartao(45, meuCard)){
      if(meuCard.validarSenha() == true)
      {
        Console.Clear();
        Console.WriteLine("COMPRA REALIZADA");

      }else{
        Console.Clear();
        Console.WriteLine("SENHA INVALIDA");
      }
      
      
    }
    else{
      Console.WriteLine("COMPRA NEGADA");
    }
  
    
   

  }
}