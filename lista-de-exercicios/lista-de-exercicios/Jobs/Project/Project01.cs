using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Model
{
    internal class Project01 : Interface.IProject1
    {
        enum opcoesMenu
        {
            Soma = 1,
            Subtrai = 2,
            Multiplica = 3,
            Divide = 4,
            Sair = 5
        }
        public int Menu()
        {

            int option = -1;

            while (option != 0)
            {
                PrintMenuOptions();

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case (int)opcoesMenu.Soma:
                        Soma();
                        break;
                    case (int)opcoesMenu.Subtrai:
                        Subtrai();
                        break;
                    case (int)opcoesMenu.Multiplica:
                        Multiplica();
                        break;
                    case (int)opcoesMenu.Divide:
                        Divide();
                        break;
                    case (int)opcoesMenu.Sair:
                        return option;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            }

            return option;
        }

        public void PrintMenuOptions()
        {
            Console.WriteLine("Escolha a operação que deseja realizar: ");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
        }

        public void Soma()
        {
            double num1, num2, result;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("O resultado da soma é: " + result);
        }

        public void Subtrai()
        {
            double num1, num2, result;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine("O resultado da soma é: " + result);

        }
        public void Divide()
        {
            double num1, num2, result;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            result = num1 / num2;
            Console.WriteLine("O resultado da soma é: " + result);
        }


        public void Multiplica()
        {
            double num1, num2, result;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine("O resultado da soma é: " + result);
        }



    }
}
