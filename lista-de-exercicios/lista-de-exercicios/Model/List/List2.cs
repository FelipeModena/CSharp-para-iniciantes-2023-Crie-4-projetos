using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lista_de_exercicios.Entity.List.List2Entity;

namespace lista_de_exercicios.Lists
{
    internal class List2 : Interface.IList
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
            //make list of item wit name and value
            List<Item> itens = new List<Item>();

            itens.Add(new Item { Name = "Chocolate", Value = 30 });
            itens.Add(new Item { Name = "Refrigerante", Value = 50 });
            itens.Add(new Item { Name = "Bolo", Value = 45 });
            itens.Add(new Item { Name = "Sorvete", Value = 60 });
            itens.Add(new Item { Name = "Pão", Value = 15 });

            List<Item> newItensValue =PrecoFinal(itens);   

            foreach (var item in newItensValue)
            {
                Console.WriteLine("Preço Final de: " + item.Name + ", Preço: " + item.Value);
            }
        }


        private List<Item>  PrecoFinal(List<Item> itens)
        {
            foreach (var item in itens)
            {
                item.Value = item.Value * 1.25;
            }
            return itens;
        }
        private void Exercice2()
        {
            int radius = 30;

            Console.WriteLine("Area da pizza de raio " + radius + " é: " + AreaCircle(radius));
        }

        private double AreaCircle(int radius)
        {
            return (int)(Math.PI * Math.Pow(radius, 2));
        }
        private void Exercice3()
        {
            int baseTriangle = 250;
            int heightTriangle = 350;

            Console.WriteLine("Area do triangulo de base " + baseTriangle + " e altura " + heightTriangle + " é: " + AreaTriangle(baseTriangle, heightTriangle));
        }
        private double AreaTriangle(int baseTriangle, int heightTriangle)
        {
            return (baseTriangle * heightTriangle) / 2;
        }
    }
}
