using lista_de_exercicios.Jobs.Project;
using lista_de_exercicios.Lists;
using lista_de_exercicios.Model;
using lista_de_exercicios.Model.List;
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
        enum opcoesMenu
        {
            Projeto = 1,
            ListaDeExercicios = 2,
            HttpJson = 3,
            Sair = 4
        }
        static void Main(string[] args)
        {
            int option;
            while (true)
            {

                PrintMenu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case (int)opcoesMenu.Projeto:
                        chooseProject();
                        break;
                    case (int)opcoesMenu.ListaDeExercicios:
                        chooseList();
                        break;
                    case (int)opcoesMenu.HttpJson:
                        ProjectJson projectJson = new ProjectJson();
                        break;
                    case (int)opcoesMenu.Sair:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("Quer ver projeto ou lista de exercícios?");
            Console.WriteLine("1 - Projeto");
            Console.WriteLine("2 - Lista de exercícios");
            Console.WriteLine("3 - Http - Json");
            Console.WriteLine("4 - Sair");
        }

        private static void chooseProject()
        {

            Console.WriteLine("Escolha o número do projeto que deseja executar: ");
            Console.WriteLine("1 - Projeto 1: Calculadora");
            Console.WriteLine("2 - Projeto 2: Gestor de clientes CMD");
            Console.WriteLine("3 - Projeto 3: Gestor de estoque CMD");

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
                case 3:
                    Project03 project03 = new Project03();
                    project03.Menu();
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
            Console.WriteLine("4 - Abstração");

            Console.WriteLine("Digite o número da lista de exercícios: ");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n ");

            listsSelected.Add(option.ToString());

            switch (option)
            {
                case 1:
                    List1 list1 = new List1();
                    list1.Menu();
                    break;
                case 2:
                    List2 list2 = new List2();
                    list2.Menu();
                    break;
                case 3:
                    List3 list3 = new List3();
                    list3.Menu();
                    break;
                case 4:
                    AbstratactionList abstraction = new AbstratactionList();
                    abstraction.Menu();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    listsSelected.RemoveAt(listsSelected.Count - 1);
                    break;
            }
        }
    }
}
