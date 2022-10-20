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

    Dados[] alunos = new Dados[3];

    for(int n = 0; n < 3; n++){
      alunos[0].nome = "João";
      alunos[1].nome = "Maria";
      alunos[2].nome = "Jorge";

      alunos[0].idade = 25;
      alunos[1].idade = 18;
      alunos[2].idade = 17;

      alunos[0].nota = 8.5;
      alunos[1].nota = 7.5;
      alunos[2].nota = 5.5;
    }

    for(int n = 0; n < 3; n++){
      Console.WriteLine(alunos[n].nome);
      Console.WriteLine(alunos[n].idade);
      aprovacao(alunos[n].nota);
    }
  }
}