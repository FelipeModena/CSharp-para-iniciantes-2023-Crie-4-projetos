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

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Soma");
                        Soma();
                        break;
                    case 2:
                        Console.WriteLine("Subtrai");
                        Subtrai();
                        break;
                    case 3:
                        Console.WriteLine("Multiplica");
                        Multiplica();
                        break;
                    case 4:
                        Console.WriteLine("Divide");
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
