function aprovacao(nota){
    if(nota >= 7){
      console.log("Você foi aprovado")
    } else {
      console.log("Você foi reprovado")
    }
  }
  
  const dados = {"nome1": "João", "idade1": 25, "nota1": 8.5,
                "nome2": "Maria", "idade2": 18, "nota2": 7.5,
                "nome3": "Jorge", "idade3": 17, "nota3": 5.5}
  
  console.log(dados.nome1)
  console.log(dados.idade1)
  aprovacao(dados.nota1)
  
  console.log("")
  
  console.log(dados.nome2)
  console.log(dados.idade2)
  aprovacao(dados.nota2)
  
  console.log("")
  
  console.log(dados.nome2)
  console.log(dados.idade2)
  aprovacao(dados.nota3)