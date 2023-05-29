using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Entity.Project.Project03
{
    [System.Serializable]
    abstract class ProductModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public const  bool enviromentTest = true;

    }
}
