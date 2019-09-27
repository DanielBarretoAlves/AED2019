using System ;
using System.IO;
using System.Collections.Generic;

  class Cartao {
    private bool bloqueado;
    private double limite;
    private double [,] faturas;
    private List<double> compras;
    private List<string> estab;
    //construtor

    public Cartao (double l) {
      bloqueado = false;
      compras = new List<double>();// cria a lista
      estab = new List<string>();
      limite = l;
      
    }
   
    public bool comprar (double valor, string e){
      if ((limite-valor >= 0) && bloqueado==false){
        limite = limite - valor;
        compras.Add(valor);
        estab.Add(e);
        return true;
      }
      else {
        return false;
      }
      
      //list :  coleção com tipos de dados
            
    } 
    public double getFatura(){
      double soma = 0;
      bloqueado = true;
      foreach(double v in compras){
        soma = soma + v;
      }
      return soma;
    }
    //criado abaixo o metodo que:
    //bloqueia o cartao
    //soma as compras feitas
    //exibe o total da fatura
    public double fecharFatura(){
      double soma = 0;
      bloqueado = true;
      foreach (double v in compras){
        soma = soma + v;
      }
      return soma;
    }
   //implementado um metodo que:
    //reestabeleca o limite do cartao
    //desbloqueie o cartao
    //exibir confirmacao de pagamento
    // salvar a fatura atual
    public bool pagarFatura(){
      //TODO: SALVAR A FATURA
      StreamWriter saida;
      saida = File.AppendText("faturas.txt");
      //foreach (int i in compras.Count)
      for(int i=0;i<compras.Count;i++)
      {
        saida.WriteLine("{0}:{1}",estab[i], compras[i]);
      }
      saida.Close();
      
      bloqueado=false;
      limite= limite + getFatura(); 
      //HACK LIMPAR LISTAS 
      //idx = compras.Count;
     //for(int i=compras.Count-1;i>=0;i--){
      while(compras.Count > 0){
       compras.RemoveAt(0);
       estab.RemoveAt(0);
     }
      return true;
      //TODO: implementar THY CATCH
    }
    

    //TODO : ABRIR ARQUIVO DAS SENHA E VALIDAR
	
	public static bool validarSenha(){
		 StreamReader x;
 
      //Colocando o endereço físico (caminho do arquivo texto)
      string Caminho = "chave.txt";
 
      //abrindo um arquivo texto indicado
      x = File.OpenText(Caminho);
 
      //lendo conteúdo da linha do arquivo texto
      string senha = x.ReadLine();
      Console.WriteLine("Informe sua Senha");
      string senhaUs = Console.ReadLine();
      if(senhaUs == senha)
      {

        
        return true;
      }else{
        
        return false;
      }
      Console.WriteLine(senha);
 
      //escrevendo este conteúdo na tela
      //mais podemos salvar esse conteúdo em uma variável
      //do tipo string, para utilização no nosso código
     
 
      //fecha arquivo texto
      x.Close();
 

  }

    // ve a fatura com valor, mes a mes   
    public void ver_fatura(){

      foreach(double v in compras){
        Console.WriteLine(v);
      }
    }

  }
  
