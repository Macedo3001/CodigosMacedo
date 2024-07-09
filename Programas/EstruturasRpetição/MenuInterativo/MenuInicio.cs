// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosFundamentos.Programas.EstruturasRpetição.MenuInterativo
// {
//     public class MenuInicio
//     {
//         public static void Inicio(){
//             string opcao;
//             bool exibirMenu = true;

//             while(exibirMenu){
//                  Console.WriteLine("===Clientes Em Rede===");
//                 Console.WriteLine("1=Cadastrar Cliente");
//                 Console.WriteLine("2=Encontrar Cliente");
//                 Console.WriteLine("3=Apagar Cliente");
//                 Console.WriteLine("4=Encerrar Programa");
//                opcao = Console.ReadLine();
//             switch(opcao)
//             {
//             case "1":
//                  Console.WriteLine("Cadastro de Cliente");
//                  break;
//             case "2":
//                  Console.WriteLine("Cliente Encontrado");
//                  break;
//             case "3":
//                  Console.WriteLine("Cliente Apagado");
//                  break;
//             case "4":
//                  Console.WriteLine("Programa Encerrado");
//                  exibirMenu = false;
//                  break;
//             default:
//                  Console.WriteLine("Opção não encontrada");
//                  break;
// }
//                Console.WriteLine("FIM");
//             }
//         }
//     }
// }