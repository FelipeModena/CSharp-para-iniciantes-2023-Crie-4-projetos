using lista_de_exercicios.Entity.Project.Project03;
using lista_de_exercicios.Interface;
using lista_de_exercicios.Interface.Project03;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Model.Project
{
    internal class Project03 : IProject
    {
        static readonly List<IEstoque<ProdutoFisicoModel>> estoqueProdutosFisicos = new List<IEstoque<ProdutoFisicoModel>>();
        static readonly List<IEstoque<EbookModel>> estoqueEbooks = new List<IEstoque<EbookModel>>();
        static readonly List<IEstoque<CursoModel>> estoqueCursos = new List<IEstoque<CursoModel>>();

        private const string projectDbFolder = "Project03";
        private const string projectDbFile = "estoque.dat";
        enum OpcoesMenu
        {
            CadastrarProduto = 1,
            ListarProdutos = 2,
            EditarProduto = 3,
            ExcluirProduto = 4,
            Sair = 5
        }
        public int Menu()
        {
            LoadEstoque();
            int option = -1;

            while (option != 5)
            {
                PrintMenuOptions();
                option = ChooseMenuOption();
            }
            return option;

        }

        public void PrintMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao sistema de estoque");
            Console.WriteLine("O que deseja? Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Editar produto");
            Console.WriteLine("4 - Excluir produto");
            Console.WriteLine("5 - Sair");
        }

        private int ChooseMenuOption()
        {
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case (int)OpcoesMenu.CadastrarProduto:
                    AddProduct();
                    SaveEstoque();
                    break;
                case (int)OpcoesMenu.ListarProdutos:
                    ListProducts();
                    break;
                case (int)OpcoesMenu.EditarProduto:
                    EditProduct();
                    SaveEstoque();
                    break;
                case (int)OpcoesMenu.ExcluirProduto:
                    DeleteProduct();
                    SaveEstoque();
                    break;
                case (int)OpcoesMenu.Sair:
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            return option;

        }

        enum OptionsAddProduct
        {
            TodosOsProdutos = 1,
            ProdutoFisico = 2,
            Ebook = 3,
            Curso = 4,
            Sair = 5
        }
        private void AddProduct()
        {
            int option = -1;


            while (option != 5)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Cadastrar produto físico");
                Console.WriteLine("2 - Cadastrar ebook");
                Console.WriteLine("2 - Cadastrar curso");
                Console.WriteLine("5 - Sair");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case (int)OptionsAddProduct.ProdutoFisico:
                        ProdutoFisicoModel produtoFisicoModel = new ProdutoFisicoModel();
                        estoqueProdutosFisicos.Add(produtoFisicoModel.AddProduct());
                        break;
                    case (int)OptionsAddProduct.Ebook:
                        EbookModel ebookModel = new EbookModel();
                        estoqueEbooks.Add(ebookModel.AddProduct());
                        break;
                    case (int)OptionsAddProduct.Curso:
                        CursoModel cursoModel = new CursoModel();
                        estoqueCursos.Add(cursoModel.AddProduct());
                        break;
                }

            }

        }


        private void DeleteProduct()
        {
            object product = null;
            Console.WriteLine("Digite o nome do produto que deseja excluir: ");
            string name = Console.ReadLine();
            string output = " excluído com sucesso. Aperte qualquer tecla para continuar.";

            if (estoqueProdutosFisicos.Any(item => item.FindProductByName(name)))
            {
                product = estoqueProdutosFisicos.Find(item => item.FindProductByName(name));
                estoqueProdutosFisicos.Remove((IEstoque<ProdutoFisicoModel>)product);
                output = "Produto fisico" + output;
                Console.ReadKey();
            }
            else if (estoqueEbooks.Any(item => item.FindProductByName(name)))
            {
                product = estoqueEbooks.Find(item => item.FindProductByName(name));
                estoqueEbooks.Remove((IEstoque<EbookModel>)product);
                output = "Ebook" + output;
                Console.ReadKey();
            }
            else if (estoqueCursos.Any(item => item.FindProductByName(name)))
            {
                product = estoqueCursos.Find(item => item.FindProductByName(name));
                estoqueCursos.Remove((IEstoque<CursoModel>)product);
                output = "Curso" + output;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Produto não encontrado. Aperte qualquer tecla para continuar.");
            }
            Console.ReadKey();
        }

        private void EditProduct()
        {
            throw new NotImplementedException();
        }
        private enum OptionsListProduct
        {
            TodosOsProdutos = 1,
            ProdutoFisico = 2,
            Ebook = 3,
            Curso = 4,
            Sair = 5
        }
        private void ListProducts()
        {


            int option = -1;

            while (option != 5)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Listar todos os produtos");
                Console.WriteLine("2 - Listar produtos físicos");
                Console.WriteLine("2 - Listar ebooks");
                Console.WriteLine("2 - Listar cursos");
                Console.WriteLine("5 - Sair");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case (int)OptionsAddProduct.TodosOsProdutos:
                        estoqueProdutosFisicos.ForEach(item => item.ListProduct());
                        estoqueEbooks.ForEach(item => item.ListProduct());
                        estoqueCursos.ForEach(item => item.ListProduct());
                        break;
                    case (int)OptionsAddProduct.ProdutoFisico:
                        estoqueProdutosFisicos.ForEach(item => item.ListProduct());
                        break;
                    case (int)OptionsAddProduct.Ebook:
                        estoqueEbooks.ForEach(item => item.ListProduct());
                        break;
                    case (int)OptionsAddProduct.Curso:
                        estoqueCursos.ForEach(item => item.ListProduct());
                        break;
                    case (int)OptionsAddProduct.Sair:
                        return;
                }

                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadKey();
            }

        }
        static void SaveEstoque()
        {

            string path = projectDbFolder + '/' + projectDbFile;

            if (CheckFolderExists())
            {
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter binaryFormatter = new BinaryFormatter();


                binaryFormatter.Serialize(fileStream, estoqueCursos);
                binaryFormatter.Serialize(fileStream, estoqueEbooks);
                binaryFormatter.Serialize(fileStream, estoqueProdutosFisicos);
                fileStream.Close();
            }



        }

        static private void LoadEstoque()
        {

            string path = projectDbFolder + '/' + projectDbFile;

            if (CheckFolderExists())
            {
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                try
                {
                    estoqueCursos.AddRange((List<IEstoque<CursoModel>>)binaryFormatter.Deserialize(fileStream));
                    estoqueEbooks.AddRange((List<IEstoque<EbookModel>>)binaryFormatter.Deserialize(fileStream));
                    estoqueProdutosFisicos.AddRange((List<IEstoque<ProdutoFisicoModel>>)binaryFormatter.Deserialize(fileStream));

                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao carregar o arquivo" + e);
                }
                fileStream.Close();
            }
        }

        static private bool CheckFolderExists()
        {
            bool exists = Directory.Exists(projectDbFolder);
            if (!exists) Directory.CreateDirectory(projectDbFolder);
            return exists;
        }
    }
}
