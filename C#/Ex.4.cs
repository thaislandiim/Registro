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
      funcionarios[] dados = new funcionarios[10];

      for(int n = 0; n < 10; n++){
        Console.WriteLine("Insira o nome do funcionario: ");
        dados[n].nome = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Insira a idade do funcionario: ");
        dados[n].idade = Convert.ToInt32(Console.ReadLine());
      }

      Console.WriteLine("Lista com todos os funcinários: ");
      for(int n = 0; n<10; n++){
        Console.WriteLine(dados[n].nome + " " + dados[n].idade);
      }

      Console.WriteLine("Lista com todos os funcinários menores de 18 anos: ");
      for(int n = 0; n<10; n++){
        if(exibicao(dados[n].idade, 0, 18) == true){
          Console.WriteLine(dados[n].nome + " " + dados[n].idade);
        }
      }

      Console.WriteLine("Lista com todos os funcinários com 18 até 45 anos: ");
      for(int n = 0; n<10; n++){
        if(exibicao(dados[n].idade, 18, 45) == true){
          Console.WriteLine(dados[n].nome + " " + dados[n].idade);
        }
      }

      Console.WriteLine("Lista com todos os funcinários acima de 60 anos: ");
      for(int n = 0; n<10; n++){
        if(exibicao(dados[n].idade, 60, 200) == true){
          Console.WriteLine(dados[n].nome + " " + dados[n].idade);
      }
    }
  }
}