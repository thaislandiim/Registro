function exibicao(idade, idadeMin, idadeMax){
  if(idade > idadeMin && idade < idadeMax){
    return true
  } else {
    return false
  }
}

const funcionarios = []

for(let n = 0; n < 10; n++){
  const funcionario = {}
  funcionario.nome = prompt("Insira o nome do funcionario: ")
  funcionario.idade = Number(prompt("Insira a idade do funcionário: "))
  funcionarios.push(funcionario)
}

console.log(funcionarios)

for(let n = 0; n < 10; n++){
  if(exibicao(funcionarios[n].idade, 0, 18) == true){
    console.log(funcionarios[n])
    funcionarios.push(funcionarios)
  }
}

console.log("")

for(let n = 0; n < 10; n++){
  if(exibicao(funcionarios[n].idade, 18, 45) == true){
    console.log(funcionarios[n])
    funcionarios.push(funcionarios)
  }
}

console.log("")

for(let n = 0; n < 10; n++){
  if(exibicao(funcionarios[n].idade, 60, 200) == true){
    console.log(funcionarios[n])
    funcionarios.push(funcionarios)
  }
}