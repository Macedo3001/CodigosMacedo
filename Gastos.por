programa {
  funcao inicio() {
    // Quantidade de Fralda usadas no dia
    inteiro quanTFraldas, mes
    quanTFraldas = 4
    // Total de dias do M�s que foram gasto as quantidades de fraldas
    mes = 30
    // Pre�o de cada Fralda
    real precoQuantFraldas
    precoQuantFraldas = 1.10
    // Quantidade gasta com as fraldas
    real quantxpreco
    quantxpreco = quanTFraldas * precoQuantFraldas
    // Total gasto no m�s
    real total
    total = quantxpreco * mes
    
    escreva("o valor gasto com fraldas foi de R$", total)
  }
}
