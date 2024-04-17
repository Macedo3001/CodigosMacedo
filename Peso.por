programa {
  funcao inicio() {
    real pesoMosca, peso
    pesoMosca = 52.0
    escreva("O peso está baseado na categoria Peso Mosca: Kg", pesoMosca)
    escreva("\n===========================================\n")
    escreva("Qual é o peso do lutador? Kg")
    leia(peso)
    se(peso > pesoMosca) {
      escreva("O lutador está acima do peso.")
    }
    se(peso < pesoMosca){
      escreva("O lutador está abaixo do peso.")
    }
    senao se(peso == pesoMosca)
    escreva("O lutador está no peso ideal")
  }
}

