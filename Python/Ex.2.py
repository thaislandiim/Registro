def aprovacao(nota):
  if nota >= 7:
    print("Vc foi aprovado")
  else:
    print("Vc foi reprovado")

dados = [ {'nome': 'João', "idade": 25, 'nota': 8.5},
          {'nome': 'Maria', "idade": 18, 'nota': 7.5},
          {'nome': 'Jorge', "idade": 17, 'nota': 5.5} ]

for d in dados:
  print(d['nome'])
  print(d['idade'])
  aprovacao(d['nota'])