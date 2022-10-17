def aprovacao(nota):
  if nota >= 7:
    print("Vc foi aprovado")
  else:
    print("Vc foi reprovado")

dados = {'nome1': 'João', "idade1": 25, 'nota1': 8.5,
        'nome2': 'Maria', "idade2": 18, 'nota2': 7.5,
        'nome3': 'Jorge', "idade3": 17, 'nota3': 5.5}

print(dados['nome1'])
print(dados['idade1'])
aprovacao(dados['nota1'])

print("")

print(dados['nome2'])
print(dados['idade2'])
aprovacao(dados['nota2'])

print("")

print(dados['nome3'])
print(dados['idade3'])
aprovacao(dados['nota3'])