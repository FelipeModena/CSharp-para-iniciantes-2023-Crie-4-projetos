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

        private class Aluno
        {
            public string Name { get; set; }
        }
        private void Exercice1()
        {
            List<Aluno> novosAlunos = new List<Aluno>();

            criaNovosAlunos(novosAlunos);
            imprimeAlunos(novosAlunos);
        }

        private static void imprimeAlunos(List<Aluno> novosAlunos)
        {
            foreach (var aluno in novosAlunos)
            {
                Console.WriteLine("Bem vindo Aluno " + aluno.Name);
            }
        }

        private static void criaNovosAlunos(List<Aluno> novosAlunos)
        {
            for (int i = 1; i <= 10; i++)
            {
                string name = "Aluno" + i;
                novosAlunos.Add(new Aluno { Name = name });
            }
        }

        private void Exercice2()
        {
            int velocidadeMaxima = 200;
            while (velocidadeMaxima>0)
            {
                velocidadeMaxima--;       
            }
            Console.WriteLine("Velocidade Máxima atingida: ");
        }

        private void Exercice3()
        {
            int hora = 7;

            while (hora < 18)
            {
                Console.WriteLine("Agora são " + hora + " horas");
                hora++;
            }
            Console.WriteLine("Fim do expediente");

        }
        private class Pizza
        {
           public string Sabor { get; set; }
           public string Valor { get; set; }
        }
        private void Exercice4()
        {   
            List<Pizza> cardapioPizzas = new List<Pizza>();

            for (int i = 1; i <= 10; i++)
            {
                string sabor = "Pizza" + i;
                string valor = "R$" + i + ",00";
                cardapioPizzas.Add(new Pizza { Sabor = sabor, Valor = valor });
            }

            foreach (var pizza in cardapioPizzas)
            {
                Console.WriteLine("Pizza " + pizza.Sabor + " - " + pizza.Valor);
            }
        }

        private void Exercice5()
        {
            int tempoParaLancamentoDoFoguete = 1000;

            while (tempoParaLancamentoDoFoguete>0)
            {
                tempoParaLancamentoDoFoguete--;
            }
            Console.WriteLine("FOGO!");
        }

    }
}
