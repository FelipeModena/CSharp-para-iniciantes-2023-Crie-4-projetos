using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Interface.Repository.Project03
{
    internal interface IProdutoRepository<T> 
    {
        T Create();
    }
}
