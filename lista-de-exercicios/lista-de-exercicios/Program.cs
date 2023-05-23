using lista_de_exercicios.Lists;
using lista_de_exercicios.Model;
using lista_de_exercicios.Model.Project;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios
{
    internal class Program
    {
        private static readonly List1 list1 = new List1();
        private static readonly List2 list2 = new List2();
        private static readonly List3 list3 = new List3();
        static void Main(string[] args)
        {

            Console.WriteLine("Quer ver projeto ou lista de exercícios?");
            Console.WriteLine("1 - Projeto");
            Console.WriteLine("2 - Lista de exercícios");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    chooseProject();
                    break;
                case 2:
                    chooseList();
                    break;
                default:
                    break;
            }
        }

        private static void chooseProject()
        {

            Console.WriteLine("Escolha o número do projeto que deseja executar: ");
            Console.WriteLine("1 - Projeto 1: Calculadora");
            Console.WriteLine("2 - Projeto 2: Gestor de clientes CMD");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Project01 project01 = new Project01();
                    project01.Menu();
                    break;
                case 2:
                    Project02 project02 = new Project02();
                    project02.Menu();
                    break;
                default:
                    break;
            }
        }

        private static void chooseList()
        {
            int option;
            List<string> listsSelected = new List<string>();
            Console.WriteLine("Escolha o número da lista de exercícios que deseja executar: ");
            Console.WriteLine("1 - Lista de exercícios 1");
            Console.WriteLine("2 - Lista de exercícios 2");
            Console.WriteLine("3 - Lista de exercícios 3");
            Console.WriteLine("Digite o número da lista de exercícios: ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n ");

            listsSelected.Add(option.ToString());

            switch (option)
            {
                case 1:
                    list1.Menu();
                    break;
                case 2:
                    list2.Menu();
                    break;
                case 3:
                    list3.Menu();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    listsSelected.RemoveAt(listsSelected.Count - 1);
                    break;
            }
        }
    }
}
