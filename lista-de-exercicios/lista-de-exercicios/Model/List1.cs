using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Lists
{
    internal class List1 : Interface.List
    {
        public int Menu()
        {
            int option;
            //choose betwwen exercises
            Console.WriteLine("Escolha o número do exercício que deseja executar: ");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("\n");

            Console.WriteLine("Digite o número do exercício: ");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Exercice1();
                    return option;
                case 2:
                    Exercice2();
                    return option;
                case 3:
                    Exercice3();
                    return option;
                default:
                    Console.WriteLine("Opção inválida!");
                    return 0;
            }
        }

        private void Exercice1()
        {
            List<int> ints = new List<int>();
            const int size = 3;

            Console.WriteLine("Digite" + size + "números inteiros: ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número: ");
                ints.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("O menor número é: " + ints.Min());
        }

        private void Exercice2()
        {
            List<int> ints = new List<int>();
            const int size = 3;

            Console.WriteLine("Digite" + size + "números inteiros: ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número: ");
                ints.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("O maior número é: " + ints.Max());
        }

        private void Exercice3()
        {
            Console.WriteLine("Digite o valor do chamado para o usuário: ");
            int callValue = int.Parse(Console.ReadLine());

            if (callValue >= 0 && callValue <= 3) Console.WriteLine("BAIXO");
            else if (callValue >= 4 && callValue <= 6) Console.WriteLine("MÉDIO");
            else if (callValue >= 7 && callValue <= 9) Console.WriteLine("ALTO");
            else Console.WriteLine("GRAVE");
        }
    }
}
