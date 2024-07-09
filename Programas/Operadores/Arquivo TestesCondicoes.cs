// Arquivo TestesCondicoes.cs
using System;

namespace ExemplosFundamentos.TiposDeDados
{
    public class TestesCondicoes
    {
        public static void Executar()
        {
            int quantidadeEstoque = 10;
            int quantidadeCompra = 12;
            bool porventuraVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

            Console.WriteLine($"Quantidade de estoque: {quantidadeEstoque}");
            Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
            Console.WriteLine($"É possível realizar a venda? {porventuraVenda}");

            if (quantidadeCompra == 0)
            {
                Console.WriteLine($"Você não comprou nada. Itens: {quantidadeCompra}");
            }
            else if (porventuraVenda)
            {
                Console.WriteLine("Temos o estoque completo, agradeço a compra.");
            }
            else
            {
                Console.WriteLine("Estamos em falta, a compra não foi fechada.");
            }
        }
    }
}
