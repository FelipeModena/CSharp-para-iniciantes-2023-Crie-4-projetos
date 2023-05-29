using lista_de_exercicios.Entity.Project.Project03;
using lista_de_exercicios.Interface.Entity;
using lista_de_exercicios.Interface.Repository.Project03;
using lista_de_exercicios.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Repository.Project.Project03
{
    internal class ProdutoFisicoRepository : IProdutoFisicoRepository
    {
        private double Amount { get; set; }
        private double TransportTax { get; set; }

        public ProdutoFisicoModel Create()
        {
            throw new NotImplementedException();
        }
    }
}
