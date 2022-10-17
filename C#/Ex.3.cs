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
  
  static void autorizacao(int idade, string liberar){
    if (idade >= 18 && liberar == "sim"){
      Console.WriteLine("Você pode entrar no evento");
    } else{
      Console.WriteLine("Você não pode entrar no evento");
    }
  }
  
  public static void Main (string[] args) {
    autorizacao a1;
    autorizacao a2;
    autorizacao a3;
    autorizacao a4;

    a1.nome = "João";
    a1.idade = 25;
    a1.liberar = "sim";

    a2.nome = "Maria";
    a2.idade = 15;
    a2.liberar = "sim";

    a3.nome = "Jorge";
    a3.idade = 17;
    a3.liberar = "não";

    a4.nome = "Tânia";
    a4.idade = 14;
    a4.liberar = "não";

    Console.WriteLine(a1.nome);
    Console.WriteLine(a1.idade);
    autorizacao(a1.idade, a1.liberar);

    Console.WriteLine("");

    Console.WriteLine(a2.nome);
    Console.WriteLine(a2.idade);
    autorizacao(a2.idade, a2.liberar);

    Console.WriteLine("");

    Console.WriteLine(a3.nome);
    Console.WriteLine(a3.idade);
    autorizacao(a3.idade, a3.liberar);

    Console.WriteLine("");

    Console.WriteLine(a4.nome);
    Console.WriteLine(a4.idade);
    autorizacao(a4.idade, a4.liberar);
  }
}