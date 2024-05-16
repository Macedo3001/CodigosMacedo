using System;
//Usando o operador AND ||
namespace ExemplosFundamentos
{
    public static class Operadorand
    {
        public static void Metodoand()
        {
        bool presencaMinima = true;
        double media = 3;
        if (presencaMinima && media >= 7){
            Console.WriteLine("Aprovado");
        }
        else{
            Console.WriteLine("Reprovado passou");
        }
        }
    }
}
