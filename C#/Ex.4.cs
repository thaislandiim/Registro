  using System;

  struct funcionarios{
    public string nome;
    public int idade;

    public funcionarios(string nome, int idade){
      this.nome = nome;
      this.idade = idade;
    }
}

class Program {
  static bool exibicao(int idade, int idadeMin, int idadeMax){
    if (idade > idadeMin && idade < idadeMax){
      return true;
    } else return false;
  }
  public static void Main (string[] args) {
    string[] nome = new string [10];
    int[] idade = new int [10];

    for(int n=0; n <10; n++){
    Console.WriteLine($"Digite o nome do funcionário {n}: ");
    nome[n] = Convert.ToString(Console.ReadLine());

    Console.WriteLine($"Digite a idade do funcionário {n}: ");
    idade[n] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Lista com todos os funcionários: ");
    for(int n = 0; n<10; n++){
      Console.WriteLine(nome[n] + idade[n]);
    }
    
    Console.WriteLine("");

    Console.WriteLine("Lista com todos os funcionários até 18 anos: ");
    for(int n = 0; n<10; n++){
      if(exibicao(idade[n], 0, 18) == true){
        Console.WriteLine(nome[n] + " " + idade[n]);
      }
    }

    Console.WriteLine("");

    Console.WriteLine("Lista com todos os funcionários com 18 até 45 anos: ");
    for(int n = 0; n<10; n++){
      if(exibicao(idade[n], 18, 45) == true){
        Console.WriteLine(nome[n] + " " + idade[n]);
      }
    }

    Console.WriteLine("");

    Console.WriteLine("Lista com todos os funcionários maiores de 60 anos: ");
    for(int n = 0; n<10; n++){
      if(exibicao(idade[n], 60, 200) == true){
        Console.WriteLine(nome[n] + " " + idade[n]);
      }
    }
  }
}