def exibicao(idade, idadeMin, idadeMax):
  if idade > idadeMin and idade < idadeMax:
    return "vdd"

nome = [0,0,0,0,0,0,0,0,0,0]
idade = [0,0,0,0,0,0,0,0,0,0]

for n in range(0,10):
  nome[n] = input("Insira o nome do funcionário: ")
  idade[n] = int(input("Insira a idade do funcinário: "))

print("")
  
print("Lista com nome e idade dos funcinários")
for n in range(0,10):
  print(nome[n], idade[n])

print("")

print("Lista com pessoas com até 18 anos")
for n in range(0,10):
  if exibicao (idade[n], 0, 18) == "vdd":
    print(idade[n], nome[n])

print("")

print("Lista com pessoas entre 18 e 45 anos")
for n in range(0,10):
  if exibicao (idade[n], 18, 45) == "vdd":
    print(idade[n], nome[n])

print("")

print("Lista com pessoas acima de 60 anos")
for n in range(0,10):
  if exibicao (idade[n], 60, 200) == "vdd":
    print(idade[n], nome[n])