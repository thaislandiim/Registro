using System;

  struct autorizacao{
    public string nome;
    public int idade;
    public string liberar;

    public autorizacao(string nome, string liberar, int idade){
      this.nome = nome;
      this.idade = idade;
      this.liberar = liberar;
    }
  }

class Program {
  
  static void autorizar(int idade, string liberar){
    if (idade >= 18 && liberar == "sim"){
      Console.WriteLine("Você pode entrar no evento");
    } else{
      Console.WriteLine("Você não pode entrar no evento");
    }
  }
  
  public static void Main (string[] args) {
    autorizacao[] dados = new autorizacao[4];

    for(int n = 0; n < 4; n++){
      dados[0].nome = "João";
      dados[1].nome = "Jorge";
      dados[2].nome = "Maria";
      dados[3].nome = "Tânia";
      
      dados[0].idade = 25;
      dados[1].idade = 17;
      dados[2].idade = 15;
      dados[3].idade = 14;

      dados[0].liberar = "sim";
      dados[1].liberar = "não";
      dados[2].liberar = "sim";
      dados[3].liberar = "não";
    }

    for(int n = 0; n < 4; n++){
      Console.WriteLine(dados[n].nome);
      Console.WriteLine(dados[n].idade);
      autorizar(dados[n].idade, dados[n].liberar);
    }
  }
}