using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_exercicios.Interface
{
    internal interface IProject
    {
        int Menu();
    }

    internal interface IProject1 : IProject
    {
        void Soma();
        void Subtrai();
        void Multiplica();
        void Divide();

    }
    


}
