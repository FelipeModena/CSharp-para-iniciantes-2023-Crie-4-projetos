using lista_de_exercicios.Entity.Project.Project03;
using lista_de_exercicios.Interface.Entity;
using lista_de_exercicios.Interface.Repository.Project03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Repository.Entity
{
    class ProdutoFisicoEntity : ProdutoEntity
    {
		private double Amount { get; set; }
		private double TransportTax { get; set; }
		public ProdutoFisicoEntity(string name, double price, double amount, double transportTax)
		{
			Amount = amount;
			TransportTax = transportTax;
			this.Name = name;
			this.Price = price;
		}

    }
}
