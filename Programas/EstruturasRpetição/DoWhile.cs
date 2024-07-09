using System;
using System.Runtime.InteropServices;
namespace ExemplosFundamentos;
  public static class TerceiraStructDoWhile
    {
        public static void EstruturaDpWhile()
        {
        int soma = 0, numero = 0;
            do{


               Console.WriteLine("Digite um número:[0 para]");
                numero = Convert.ToInt32(Console.ReadLine());
            
        soma += numero;



            }while(numero != 0);

            Console.WriteLine("Somando todos os números digitados...");
            Console.WriteLine(soma);
    }
}