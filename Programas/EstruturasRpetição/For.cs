using System;
namespace ExemplosFundamentos;
  public static class PrimeiraEstructFor
    {
        public static void EstruturaFor()
        {
            int numero = 5;
            for (int i = 0; i <= 10; i++)
            {
              Console.WriteLine($"{numero} x {i} = {i*numero}");
            }
        }
    }