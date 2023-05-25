using lista_de_exercicios.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Model.Project
{
    internal class Project03 : IProject
    {
        enum opocesMenu
        {
            CadastrarProduto = 1,
            ListarProdutos = 2,
            EditarProduto = 3,
            ExcluirProduto = 4,
            Sair = 5
        }
        public int Menu()
        {
            int option = -1;
            while (option != 5)
            {
                PrintMenuOptions();

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case (int)opocesMenu.CadastrarProduto:
                        AddProduct();
                        break;
                    case (int)opocesMenu.ListarProdutos:
                        ListProducts();
                        break;
                    case (int)opocesMenu.EditarProduto:
                        EditProduct();
                        break;
                    case (int)opocesMenu.ExcluirProduto:
                        DeleteProduct();
                        break;
                    case (int)opocesMenu.Sair:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            }
            return int.Parse(Console.ReadLine());
        }

        public  void PrintMenuOptions()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Editar produto");
            Console.WriteLine("4 - Excluir produto");
            Console.WriteLine("5 - Sair");
        }

        private void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        private void EditProduct()
        {
            throw new NotImplementedException();
        }

        private void ListProducts()
        {
            throw new NotImplementedException();
        }

        private void AddProduct()
        {
            throw new NotImplementedException();
        }
    }
}
