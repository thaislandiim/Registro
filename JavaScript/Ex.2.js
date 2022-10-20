function aprovacao(nota){
  if(nota >= 7){
    console.log("Você foi aprovado")
  } else {
    console.log("Você foi reprovado")
  }
}

const dados = [ {"nome": "João", "idade": 25, "nota": 8.5},
                {"nome": "Maria", "idade": 18, "nota": 7.5},
                {"nome": "Jorge", "idade": 17, "nota": 5.5} ]

for(let n = 0; n < 3; n++){
  dados[0].nome = "João"
  dados[1].nome = "Maria"
  dados[2].nome = "Jorge"

  dados[0].idade = 25
  dados[1].idade = 18
  dados[2].idade = 17

  dados[0].nota = 8.5
  dados[1].nota = 7.5
  dados[2].nota = 5.5
}

for(let n = 0; n < 3; n++){
  console.log(dados[n].nome)
  console.log(dados[n].idade)
  aprovacao(dados[n].nota)
}