programa {
  funcao inicio() {
    escreva("Açaí: 12.00\n")
    escreva("Tapioca: 18:00\n")
    //Declaração de preços 
   real acai, tapioca 
    acai = 12.00
    tapioca = 18.00
   // Declaração de variáveis 
    inteiro soma, numerodeop, pagamento
    real totaldeCompra
    soma = acai + tapioca
      //Interaçaõ do Usuário 
    escreva(" Digite quantos AT você deseja: ")
    leia(numerodeop)
    totaldeCompra = soma * numerodeop
    escreva("A sua compra atual é de R$", totaldeCompra)
          //Forma de pagamento 
    escreva("\nDigite 1 para PIX ou qualquer outra tecla para dinheiro em espécie: ")
    leia(pagamento)
    se(totaldeCompra >= 100 e pagamento == 1){
      real desconto = totaldeCompra - totaldeCompra*15/100 
      escreva("O total foi acima de R$100 faremos 15% de desconto.\n")
      escreva("Preço com desconto: R$", desconto)
    }
    senao se(totaldeCompra >= 100 e pagamento != 1){
      real desconto1 = totaldeCompra - totaldeCompra*10/100
      escreva("O total foi acima de R$100 faremos 10% de desconto.\n")
      escreva("Preço com desconto: R$", desconto1)
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
