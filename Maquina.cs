class Maquina {
//ATRIBUTOS
private string estabelecimento;

public Maquina (string e){
  estabelecimento = e;
}

public bool inserirCartao(double v, Cartao c){
   if (c.comprar(v, estabelecimento)==true){
      return true;
   }
   else{
     return false;
   }
}

}