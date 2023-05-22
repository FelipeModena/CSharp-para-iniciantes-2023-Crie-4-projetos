using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Model
{
    internal class List3 : Interface.List
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
                case 4:
                    Exercice4();
                    return option;
                case 5:
                    Exercice5();
                    return option;
                default:
                    Console.WriteLine("Opção inválida!");
                    return 0;
            }
        }

        private void Exercice1()
        {
            throw new NotImplementedException();
        }

        private void Exercice2()
        {
            throw new NotImplementedException();
        }

        private void Exercice3()
        {
            throw new NotImplementedException();
        }

        private void Exercice4()
        {
            throw new NotImplementedException();
        }

        private void Exercice5()
        {
            throw new NotImplementedException();
        }
    }
}
