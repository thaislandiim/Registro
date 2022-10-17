function exibicao(idade, idadeMin, idadeMax){
    if(idade > idadeMin && idade < idadeMax){
      return true
    } 
  }
  
  idade = [0,0,0,0,0,0,0,0,0,0]
  nome = [0,0,0,0,0,0,0,0,0,0]
  
  for(let n = 0; n<10; n++){
    nome[n] = prompt("Digite o nome do funcionário: ")
    idade[n] = Number(prompt("Digite a idade do funcionário: "))
  }
  
  console.log("Lista com todos os funcinários: ")
  for(let n = 0; n<10; n++){
      console.log(nome[n] + " " + idade[n]);
  }
  
  console.log("")
  
  console.log("Lista com todos os funcinários menores de 18 anos: ")
  for(let n = 0; n<10; n++){
    if(exibicao(idade[n], 0, 18) == true){
      console.log(nome[n] + " " + idade[n]);
    }
  }
  
  console.log("")
  
  console.log("Lista com todos os funcinários com 18 até 45 anos: ")
  for(let n = 0; n<10; n++){
    if(exibicao(idade[n], 18, 45) == true){
      console.log(nome[n] + " " + idade[n]);
    }
  }
  
  console.log("")
  
  console.log("Lista com todos os funcinários acima de 60 anos: ")
  for(let n = 0; n<10; n++){
    if(exibicao(idade[n], 60, 200) == true){
      console.log(nome[n] + " " + idade[n]);
    }
  }