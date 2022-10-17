function autorizacao(idade, liberar){
    if(idade >= 18 && liberar == "sim"){
      console.log("Você pode entrar no evento")
    } else {
      console.log("Você não pode entrar no evento")
    }
  }
  
  const visitante = {"nome1": "João", "idade1": 25, "liberar1": "sim",
                    "nome2": "João", "idade2": 25, "liberar2": "sim",
                    "nome3": "João", "idade3": 25, "liberar3": "nao",
                    "nome4": "João", "idade4": 25, "liberar4": "nao"}
  
  console.log(visitante.nome1)
  console.log(visitante.idade1)
  autorizacao(visitante.idade1, visitante.liberar1)
  
  console.log("")
  
  console.log(visitante.nome2)
  console.log(visitante.idade2)
  autorizacao(visitante.idade2, visitante.liberar2)
  
  console.log("")
  
  console.log(visitante.nome3)
  console.log(visitante.idade3)
  autorizacao(visitante.idade3, visitante.liberar3)
  
  console.log("")
  
  console.log(visitante.nome4)
  console.log(visitante.idade4)
  autorizacao(visitante.idade4, visitante.liberar4)