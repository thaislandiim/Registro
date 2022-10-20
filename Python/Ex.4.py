def exibicao(idade, idadeMin, idadeMax):
  if idade > idadeMin and idade < idadeMax:
    return "vdd"

funcionarios = []

for f in range(0,10):
  funcionarios.append({'nome': None, 'idade': None})

for f in range(0,10):
  funcionarios[f]['nome'] = input("Insira o nome do funcionario: ")
  funcionarios[f]['idade'] = int(input("Insira a idade do funcionario: "))

print("Lista com todos os funcinários: ")
for f in range(0,10):
  print(funcionarios[f]['nome'], funcionarios[f]['idade'])

print("")

print("Lista com todos os funcinários menores de 18 anos: ")
for f in range(0,10):
  if exibicao (funcionarios[f]['idade'], 0, 18) == "vdd":
    print(funcionarios[f]['nome'], funcionarios[f]['idade'])

print("")

print("Lista com todos os funcinários com 18 até 45 anos: ")
for f in range(0,10):
  if exibicao (funcionarios[f]['idade'], 18, 45) == "vdd":
    print(funcionarios[f]['nome'], funcionarios[f]['idade'])

print("")

print("Lista com todos os funcinários acima de 60 anos: ")
for f in range(0,10):
  if exibicao (funcionarios[f]['idade'], 60, 200) == "vdd":
    print(funcionarios[f]['nome'], funcionarios[f]['idade'])
