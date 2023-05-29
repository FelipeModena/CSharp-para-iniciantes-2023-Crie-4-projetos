using lista_de_exercicios.Interface.Project03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lista_de_exercicios.Entity.Project.Project03
{
    [System.Serializable]
    internal class ProdutoFisicoModel : ProductModel, IEstoque<ProdutoFisicoModel>
    {
        public double Amount { get; set; }
        public double TransportTax { get; set; }

        public ProdutoFisicoModel AddProduct()
        {
            ProdutoFisicoModel produto = new ProdutoFisicoModel();
            Random Random = new Random();
            Console.WriteLine("Digite o nome do produto");
            produto.Name = enviromentTest ? $"Produto ${Random.Next(100)}" : Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            produto.Price = enviromentTest ? Random.Next(100) : double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto");
            produto.Amount = enviromentTest ? 1 : double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do frete");
            produto.TransportTax = enviromentTest ? Random.Next(9) : double.Parse(Console.ReadLine());

            Console.WriteLine("Produto fisico cadastrado com sucesso");
            return produto;
        }

        public bool FindProductByName(string name)
        {
            return this.Name == name;
        }

        public void ListProduct()
        {
            Console.WriteLine($"Nome: {this.Name} | Preço: {this.Price} | Quantidade: {this.Amount} | Valor do frete: {this.TransportTax}");
        }
    }
}
