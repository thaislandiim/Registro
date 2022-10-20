def autorizacao(idade, liberar):
  if idade >= 18 and liberar == 'sim':
    print("Você pode entrar no evento")
  else:
    print("Você não pode entrar no evento")

visitante = [ {'nome': 'João', 'idade': 25, 'liberar': 'sim'},
              {'nome': 'Maria', 'idade': 18, 'liberar': 'sim'},
              {'nome': 'Jorge', 'idade': 17, 'liberar': 'não'} ] 

for v in visitante:
  print(v['nome'])
  print(v['idade'])
  autorizacao(v['idade'], v['liberar'])