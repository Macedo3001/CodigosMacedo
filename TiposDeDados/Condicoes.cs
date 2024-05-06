using ExemplosFundamentos.TiposDeDados;



//Operadores condicionais na prática

int quantidadeEstoque = 10;
int quantidadeCompra = 4;
bool porventuraVenda = quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade de estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {porventuraVenda}");




if (porventuraVenda)
{
    Console.WriteLine("Temos o estoque completo, agradeço a compra.");
}

else{
    Console.WriteLine("Estamos em falta, a compra não foi fechada.");
}