programa {
  funcao inicio() {
    escreva("A�a�: 12.00\n")
    escreva("Tapioca: 18:00\n")
    //Declara��o de pre�os 
   real acai, tapioca 
    acai = 12.00
    tapioca = 18.00
   // Declara��o de vari�veis 
    inteiro soma, numerodeop, pagamento
    real totaldeCompra
    soma = acai + tapioca
      //Intera�a� do Usu�rio 
    escreva(" Digite quantos AT voc� deseja: ")
    leia(numerodeop)
    totaldeCompra = soma * numerodeop
    escreva("A sua compra atual � de R$", totaldeCompra)
          //Forma de pagamento 
    escreva("\nDigite 1 para PIX ou qualquer outra tecla para dinheiro em esp�cie: ")
    leia(pagamento)
    se(totaldeCompra >= 100 e pagamento == 1){
      real desconto = totaldeCompra - totaldeCompra*15/100 
      escreva("O total foi acima de R$100 faremos 15% de desconto.\n")
      escreva("Pre�o com desconto: R$", desconto)
    }
    senao se(totaldeCompra >= 100 e pagamento != 1){
      real desconto1 = totaldeCompra - totaldeCompra*10/100
      escreva("O total foi acima de R$100 faremos 10% de desconto.\n")
      escreva("Pre�o com desconto: R$", desconto1)
    }
    senao se(totaldeCompra <= 100 e pagamento != 1){
      escreva("Obrigado por comprar.")
    }
    senao{
      escreva("Compra finalizada")
    }
    }
  }
}
