using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Model
{
    internal class Project01 : Interface.IProject1
    {
        public int Menu()
        {
            int option;

            do
            {
                printMenuOptions();
                option = int.Parse(Console.ReadLine());
                Console.WriteLine(option == 1);

                switch (option)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtrai();
                        break;
                    case 3:
                        Multiplica();
                        break;
                    case 4:
                        Divide();
                        break;
                    default:
                        break;
                }
            } while (option != 0);

            return option;
        }

        private static void printMenuOptions()
        {
            Console.WriteLine("Escolha a operação que deseja realizar: ");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
        }

        public void Soma()
        {
           int num1, num2, result;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("O resultado da soma é: " + result);
        }

        public void Subtrai()
        {
            int num1, num2, result;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine("O resultado da soma é: " + result);

        }
        public void Divide()
        {
            int num1, num2, result;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            result = num1 / num2;
            Console.WriteLine("O resultado da soma é: " + result);
        }


        public void Multiplica()
        {
            int num1, num2, result;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine("O resultado da soma é: " + result);
        }
    }
}
