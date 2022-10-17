using System;

struct Dados{
  public string nome;
  public int idade;
  public double nota;

  public Dados(string nome, int idade, double nota){
    this.nome = nome;
    this.idade = idade;
    this.nota = nota;
  }
}

class Program {
  
  static void aprovacao(double nota){
    if (nota >= 7){
      Console.WriteLine("Você foi aprovado");
    } else {
      Console.WriteLine("Você foi reprovado");
    }
  }
  
  public static void Main (string[] args) {
    Dados d1;
    Dados d2;
    Dados d3;

    d1.nome = "João";
    d1.idade = 25;
    d1.nota = 8.5;

    d2.nome = "Maria";
    d2.idade = 18;
    d2.nota = 7.5;

    d3.nome = "Jorge";
    d3.idade = 17;
    d3.nota = 5.5;

    Console.WriteLine(d1.nome);
    Console.WriteLine(d1.idade);
    aprovacao(d1.nota);

    Console.WriteLine("");

    Console.WriteLine(d2.nome);
    Console.WriteLine(d2.idade);
    aprovacao(d2.nota);

    Console.WriteLine("");
    
    Console.WriteLine(d3.nome);
    Console.WriteLine(d3.idade);
    aprovacao(d3.nota);
  }
}