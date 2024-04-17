programa {
  funcao inicio() {
    inteiro menorIdade = 0, maiorIdade = 0, idade

    para (inteiro cont = 1; cont <= 6; cont++) {
      escreva("Digite a ", cont, "º idade: ")
      leia(idade)

      se (cont == 1) {
        maiorIdade = idade
        menorIdade = idade
      } senao {
        se (idade > maiorIdade) {
          maiorIdade = idade
        }
        se (idade < menorIdade) {
          menorIdade = idade
        }
      }
    }

    escreva("\nMaior idade: ", maiorIdade)
    escreva("\nMenor idade: ", menorIdade)
  }
}

