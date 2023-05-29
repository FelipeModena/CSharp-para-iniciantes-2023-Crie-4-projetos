using lista_de_exercicios.Interface.Project03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Entity.Project.Project03
{
    [System.Serializable]
    internal class CursoModel : ProductModel, IEstoque<CursoModel>
    {
        public string Autor { get; set; }
        private int Vacancies { get; set; }


        public CursoModel AddProduct()
        {
            CursoModel curso = new CursoModel();
            Random Random = new Random();

            Console.WriteLine("Digite o nome do produto");
            curso.Name = enviromentTest ? $"Produto ${Random.Next(100)}" : Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            curso.Price = enviromentTest ? Random.Next(1000) :  double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do autor");
            curso.Autor = enviromentTest ? $"Autor {Random.Next(1000)}" : Console.ReadLine();
            Console.WriteLine("Número de vagas");
            curso.Vacancies = enviromentTest ? Random.Next(50) : int.Parse(Console.ReadLine());

            Console.WriteLine("Produto fisico cadastrado com sucesso");
            return curso;
        }

        public bool FindProductByName(string name)
        {
            return this.Name == name;
        }

        public void ListProduct()
        {
                Console.WriteLine($"Nome: {this.Name} | Preço: {this.Price} | Autor: {this.Autor} | Número de vagas: {this.Vacancies}");
        }
    }
}
