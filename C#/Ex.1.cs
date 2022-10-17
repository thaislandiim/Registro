using System;

struct Dados{
  public string nome;
  public int idade;

  public Dados(string nome, int idade){
    this.nome = nome;
    this.idade = idade;
  }
}
class Program {
  public static void Main (string[] args) {
    Dados d1;

    d1.nome = "João";
    d1.idade = 25;

    Console.WriteLine(d1.nome);
    Console.WriteLine(d1.idade);
  }
}