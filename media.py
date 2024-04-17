def calcular_media(num1, num2, num3):
    media = (num1 + num2 + num3) / 3
    return media

# Solicita os números ao usuário
numero1 = float(input("Digite o primeiro número: "))
numero2 = float(input("Digite o segundo número: "))
numero3 = float(input("Digite o terceiro número: "))

# Calcula a média e exibe o resultado
media = calcular_media(numero1, numero2, numero3)
print("A média dos números é:", media)
