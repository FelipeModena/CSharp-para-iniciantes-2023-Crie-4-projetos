using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Interface.Project03
{

    public interface IEstoque<T>  { 
        T AddProduct();
        void ListProduct();
        bool FindProductByName(string name);
    }
}
