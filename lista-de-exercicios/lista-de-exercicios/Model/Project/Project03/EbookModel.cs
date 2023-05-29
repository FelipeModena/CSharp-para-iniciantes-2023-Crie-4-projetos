using lista_de_exercicios.Interface.Project03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Entity.Project.Project03
{
    [System.Serializable]
    internal class EbookModel : ProductModel, IEstoque<EbookModel>
    {
        public string Autor { get; set; }
        private int Sells { get; set; }

        public EbookModel AddProduct()
        {
            EbookModel ebook = new EbookModel();
            Random Random = new Random();

            Console.WriteLine("Digite o nome do produto");
            ebook.Name = enviromentTest ? $"Produto ${Random.Next(100)}" : Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            ebook.Price = enviromentTest ? Random.Next(100) : double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do autor");
            ebook.Autor = enviromentTest ? $"Autor {Random.Next(1000)}" : Console.ReadLine();
            Console.WriteLine("Número de vendas");
            ebook.Sells =  enviromentTest ? Random.Next(1000) : int.Parse(Console.ReadLine());

            Console.WriteLine("Produto fisico cadastrado com sucesso");
            return ebook;
        }

        public bool FindProductByName(string name)
        {
            return this.Name == name;
        }

        public void ListProduct()
        {
                Console.WriteLine($"Nome: {this.Name} | Preço: {this.Price} | Autor: {this.Autor} | Número de vendas: {this.Sells}");
        }
    }
}
