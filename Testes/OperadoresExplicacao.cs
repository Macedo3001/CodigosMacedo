// Arquivo OperadoresExplicacao.cs
using System;

namespace ExemplosFundamentos.Operadores
{
    public class OperadoresExplicacao
    {
        public static void Executar()
        {
            bool maiorIdade = true;
            bool autorizacaoRespon = true;

            if (maiorIdade || autorizacaoRespon)
            {
                Console.WriteLine("Entrada Liberada");
            }
            else
            {
                Console.WriteLine("Entrada Negada");
            }
        }
    }
}
