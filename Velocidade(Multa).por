programa {
  funcao inicio() {
    real velocidade
    real limite
    limite = 80.0
    escreva("Velocidade do carro: Kg")
    leia(velocidade)
    
    se(velocidade > limite) {
      escreva("Limite de velocidade ultrapassado. Status: MULTADO!")
    } senao se(velocidade == limite) {
      escreva("Você está no limite da velocidade aceita. Por favor, diminua a sua velocidade.")
    } senao {
      escreva("Velocidade baixa, sem multa.")
    }
  }
}

