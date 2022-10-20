function autorizacao(idade, liberar){
  if(idade >= 18 && liberar == "sim"){
    console.log("Você pode entrar no evento")
  } else {
    console.log("Você não pode entrar no evento")
  }
}

const visitante = [ {"nome": "João", "idade": 25, "liberar": "sim"},
                    {"nome": "Maria", "idade": 17, "liberar": "sim"},
                    {"nome": "Jorge", "idade": 15, "liberar": "nao"},
                    {"nome": "Tânia", "idade": 14, "liberar": "nao"} ]

for(let n = 0; n < 4; n++){
  console.log(visitante[n].nome)
  console.log(visitante[n].idade)
  autorizacao(visitante[n].idade, visitante[n].liberar)
}