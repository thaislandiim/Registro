def autorizacao(idade, liberar):
  if idade > 19 and liberar == 'sim':
    print("Você pode entrar no evento")
  else:
    print("Você não pode entrar no evento")

visitante = {'nome1': 'João', "idade1": 25, 'liberar1': 'sim',
            'nome2': 'Maria', "idade2": 18, 'liberar2': 'sim',
            'nome3': 'Jorge', "idade3": 17, 'liberar3': 'não',
            'nome4': 'Jorge', "idade4": 17, 'liberar4': 'não'}

print(visitante['nome1'])
print(visitante['idade1'])
autorizacao(visitante['idade1'],visitante['liberar1'])

print("")

print(visitante['nome2'])
print(visitante['idade2'])
autorizacao(visitante['idade2'],visitante['liberar2'])

print("")

print(visitante['nome3'])
print(visitante['idade3'])
autorizacao(visitante['idade3'],visitante['liberar3'])

print("")

print(visitante['nome4'])
print(visitante['idade4'])
autorizacao(visitante['idade4'],visitante['liberar4'])