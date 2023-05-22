using lista_de_exercicios.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios
{
    internal class Program
    {
        private static List1 list1 = new List1();
        private static List2 List2 = new List2();
        static void Main(string[] args)
        {
            int option;
            //choose betwwen lists of exercises
            Console.WriteLine("Escolha o número da lista de exercícios que deseja executar: ");
            Console.WriteLine("1 - Lista de exercícios 1");
            Console.WriteLine("2 - Lista de exercícios 2");


            Console.WriteLine("Digite o número da lista de exercícios: ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n ");

            switch (option)
            {
                case 1:
                    list1.Menu();
                    break;
                case 2:
                    List2.Menu();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
